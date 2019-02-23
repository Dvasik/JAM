using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
  private float x;
  private float y;
  private Vector3 targetRotation;
  private Vector3 rotateValue;
  private Quaternion rotation;

  void Start()
  {
    rotation = transform.rotation;
  }

  void Update()
  {
    x = Input.GetAxis("Mouse X");
    y = Input.GetAxis("Mouse Y");
    Debug.Log(x + ":" + y);
    rotateValue = new Vector3(x, y, 0);
    targetRotation = transform.position + rotateValue;
    rotation = Quaternion.Euler(x, y, 0);
    transform.rotation = rotation;
  }
}
