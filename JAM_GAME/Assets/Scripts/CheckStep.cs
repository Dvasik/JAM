using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStep : MonoBehaviour
{
    AudioSource myClip;
    // Start is called before the first frame update
    void Start()
    {
      myClip = GetComponent<AudioSource>();
      myClip.Stop();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            myClip.Play();
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            myClip.loop = true;        
        }
    }

    void OnTriggerExit()
    {
        myClip.loop = false;
    }
}
