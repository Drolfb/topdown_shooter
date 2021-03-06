﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(
           transform.position.x + (Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime), 
           transform.position.y + (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime), 
           transform.position.z
        );
    }
}
