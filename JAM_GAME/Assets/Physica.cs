using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physica : MonoBehaviour
{
    private int i;
    // Start is called before the first frame update
    void Start()
    {
      i = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
      transform.rotation = new Quaternion(0.1f * 5.0F * Time.deltaTime * 10, 0, 0, 1);
      
      transform.rotation = new Quaternion(-0.1f * 5.0F * Time.deltaTime * 10, 0, 0, 1);
    }
}
