﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
    float q = 0;
    if (Input.GetButtonDown("Jump"))
      q = 1;
    transform.Translate(new Vector3(h / 10, q, v / 10)/* * Time.deltaTime*/);
    transform.Rotate(h, 0, 0, Space.World);
    transform.Rotate(0, 0, v, Space.World);
    transform.rotation = Quaternion.identity;
  }
}
