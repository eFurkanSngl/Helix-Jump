using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
   private Rigidbody _rb;
   [SerializeField] private float _jumpForce = 10;
   private string _materialNames;
   [SerializeField] private GameObject _splashPrefab;
   [SerializeField] private GameManager _gm;
 
   
   private void Start()
   {
      _rb = GetComponent<Rigidbody>();
      _gm = FindObjectOfType<GameManager>();

   }

   private void OnCollisionEnter(Collision other)
   {

      GameObject splash = Instantiate(_splashPrefab, transform.position + new Vector3(0f,-0.20f,0f), transform.rotation);
      splash.transform.SetParent(other.gameObject.transform);
      
      
      _rb.AddForce(Vector3.up * _jumpForce);
      _materialNames = other.gameObject.GetComponent<MeshRenderer>().material.name;
     
      
      if (_materialNames == "UnSafe (Instance)")
      {
         _gm.RestartGame();
      }
      else if (_materialNames == "LastRing (Instance)")
      {
         Debug.Log("Next Level");
      }
      
      
   }
}
