using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   private Rigidbody _rb;
   [SerializeField] private float _jumpForce = 10;
   private string _materialNames;

   private void Start()
   {
      _rb = GetComponent<Rigidbody>();
      
   }

   private void OnCollisionEnter(Collision other)
   {
      _rb.AddForce(Vector3.up * _jumpForce);
      _materialNames = other.gameObject.GetComponent<MeshRenderer>().material.name;
      Debug.Log("Materiyal adı : " + _materialNames);
   }
}
