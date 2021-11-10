using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float maxSpeed = 3.0f;
    float rotation = 0.0f;
    GameObject cam;

    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical"));

        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));
    }
    
    
    
    
} 
