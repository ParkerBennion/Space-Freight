using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Gmove : MonoBehaviour
{
     
    public float verticalInput, horizontalInput, score;
    public int height=30;
    private Rigidbody rb;
    private TagField Ground;
    Rigidbody Char;
    public int speed = 100;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        /*if (Input.GetKeyDown(KeyCode.Space)&& playerJump >= 1)
        {
            rb.velocity = transform.up * height * Time.deltaTime;
            //transform.Translate(Vector3.up*height*Time.deltaTime);
            playerJump -= 1;
            Debug.Log(playerJump + " A jump was used");
        }
        //player.transform.position.z = score; to display score this is needed.
    }*/
    }
}