using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotatai : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Cube")
          transform.rotation = new Quaternion(0, 1f, 0, 1);
    }
    /*void OnCollisionExit()
    {
        transform.rotation = new Quaternion(0, 0, 0, 1); 
    } */
}
