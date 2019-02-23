using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotationPaul : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Player")
          transform.rotation = new Quaternion(0, -1f, 0, 1);
    }
    void OnCollisionExit()
    {
        transform.rotation = new Quaternion(0, 0, 0, 1); 
    }
}
