﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interierobj : MonoBehaviour
{
  void OnCollisionEnter(Collision theCollision)
  {
    if (theCollision.gameObject.name == "Cube")
      Debug.Log("Hit the floor");
  }
  // Start is called before the first frame update
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
