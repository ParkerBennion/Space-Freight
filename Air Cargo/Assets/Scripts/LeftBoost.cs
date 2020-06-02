using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftBoost : MonoBehaviour
{
    public int speed =20;
    private Rigidbody Plane;

    private void Awake()
    {
        Plane = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Plane.AddForce( Vector3.back*speed*Time.deltaTime);
        }
    }
}