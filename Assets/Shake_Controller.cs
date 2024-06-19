using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake_Controller : MonoBehaviour
{
    [SerializeField] private Transform cam;
    
    [SerializeField] private Vector3 startPos;

    private float _initialDuration;

    [SerializeField] private float shakePower;
    [SerializeField] private float shakeDuration;
    [SerializeField] private float downAmount;

    [SerializeField] private bool isShaking = false;
    
    void Start()
    {
        cam = Camera.main.transform;
    }
    
    

    void Update()
    {
        
    }
}
