using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicVel : MonoBehaviour
{
    public int time = 5;
    public int zoom = 20;
    private Rigidbody rbp;
    
    void Start()
    {
        StartCoroutine(DestroyBullet());
        rbp = GetComponent<Rigidbody>();
        rbp.velocity = transform.forward * zoom * Time.deltaTime;
    }


    private void Update()
    {
        // transform.Translate(Vector3.up* zoom * Time.deltaTime);
        // rbp.velocity = transform.forward * zoom * Time.deltaTime;
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}