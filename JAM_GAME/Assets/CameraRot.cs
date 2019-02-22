using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRot : MonoBehaviour
{
  public GameObject go;
  public float sensitivity = 1F;
  private Camera goCamera;
  private Vector3 MousePos;
  private float MyAngle = 0F;
  // Start is called before the first frame update
    void Start()
    {
    goCamera = Camera;
    go = goCamera.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
    MousePos = Input.mousePosition;
    }

  void FixedUpdate()
  {
    if (Input.GetMouseButton(1))
    {
      MyAngle = 0;
      MyAngle = sensitivity * ((MousePos.x - (Screen.width / 2)) / Screen.width);
      goCamera.transform.RotateAround(go.transform.position, goCamera.transform.up, MyAngle);
      MyAngle = sensitivity * ((MousePos.y - (Screen.height / 2)) / Screen.height);
      goCamera.transform.RotateAround(go.transform.position, goCamera.transform.right, -MyAngle);
    }
  }
}
