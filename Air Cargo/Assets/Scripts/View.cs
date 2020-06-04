using System;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class View : MonoBehaviour
{
    public float speed = 200f, Restrict = 0f;
    public Vector3 position;
    public Transform Body;
    public Transform viewingBox;

 

    void Update()
    {
        position.x = speed * Input.GetAxis("Mouse X") * Time.deltaTime; //every frome the x cordnate on positoin will equal that of the mouse.
        position.y = speed * Input.GetAxis("Mouse Y") * Time.deltaTime;

        Body.Rotate(Vector3.up * position.x); //rotates assigned unity assets with the mouse movement around the Y axis according to the x cordinate positoin of the mouse.
        
        viewingBox.Rotate(Vector3.left * position.y);
        
        
        Restrict -= position.y;
        Restrict = Mathf.Clamp(Restrict, -85, 85f);
        transform.localRotation = Quaternion.Euler(Restrict,0,0);//stops camera from fliping over its local y axis^
        Cursor.lockState = CursorLockMode.Locked; //sets cursor mode.
    }


}