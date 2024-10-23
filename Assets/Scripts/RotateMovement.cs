using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    private float _moveX;

    private void Update()
    {
        _moveX = Input.GetAxis("Mouse X"); // Mouse X sağa solo hareket ettirmek için.

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f,_moveX * _rotateSpeed * Time.deltaTime,0f);
        }
    }
}
