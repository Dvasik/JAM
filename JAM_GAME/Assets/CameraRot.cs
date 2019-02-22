using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRot : MonoBehaviour
{
  public float sensitivity = 5;
  private float RotationX;
  private float RotationY;
  // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    RotationX += Input.GetAxis("Mouse Y") * sensitivity;
    RotationY += Input.GetAxis("Mouse X") * sensitivity;

    transform.rotation = Quaternion.Euler(-RotationX, RotationY, 0);
    }
  }
