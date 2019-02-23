using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class CameraRotation : MonoBehaviour 
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
      RotationX = Input.GetAxis("Mouse Y") * sensitivity; 
      RotationY = Input.GetAxis("Mouse X") * sensitivity; 
 
      transform.Rotate(new Vector3(RotationX, 0, 0));
      transform.Rotate(new Vector3(0, -RotationY, 0)); 
    } 
  }