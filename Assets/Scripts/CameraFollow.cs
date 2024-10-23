using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Update = Unity.VisualScripting.Update;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Vector3 offset;
    [SerializeField] private float _smoothSpeed = 0.125f;

    private void Start()
    {
        offset = transform.position - _target.position;
        // hedef ile kendi poz arasında farkı buluyor
        // Kameranın hedeften ne kadar uzak olduğunu hesapladı.
        // targetPos değişse bile kameranın hedefe uzaklığını sabit kalması için yapılıyor.
    }

    private void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + _target.position, _smoothSpeed);
        //Lerp Fonk kameranın mevcut pozdan hedef poz yumuşak bir geçiş sağlamasını yapıyor
        // TargetPos ile kameranın yeni konumunun hedefin konuma göre hesaplıyor
        // Geçişin ne kadar hızla olacağını en sonda veriyoruz.
        transform.position = newPos;
        //Kameranın yeni pozisyonu NewpOstan geliyor.
    }
}
