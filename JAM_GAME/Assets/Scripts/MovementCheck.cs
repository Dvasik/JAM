using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public float walkSpeedForward = 5f;
    public float walkSpeedStrafe = 4f;
    public float walkSpeedBack = 3f;
    public float sprintMultiplier = 2f;
    public float speed;
    public float minimumX = -360F;
    public float maximumX = 360F;
    public float minimumY = -60F;
    public float maximumY = 60F;
    public GameObject cam;
    float rotationY = 0f;
    public float sensitivityX = 0f;
    public float sensitivityY = 0f;    
    public float JumpSpeed = 5f;


    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update ()
    {
        float rotationX = cam.transform.localEulerAngles.y + Input.GetAxis ("Mouse X") * sensitivityX;
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
        cam.transform.localEulerAngles = (new Vector3(-rotationY, rotationX, 0f));
        Vector3 move = new Vector3(Input.GetAxis ("Horizontal") * walkSpeedStrafe * Time.deltaTime, 0, Input.GetAxis ("Vertical") * walkSpeedForward * Time.deltaTime);
        transform.Translate(move);
    }
    void FixedUpdate()
    {
        if (Input.GetButtonUp("Jump"))
          rb.AddForce(0, 300, 0);
    }
}
