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
    float inputX,inputZ;
    

    void UpdateInputs()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
    }

    void MoveCharacter()
    {
        transform.Translate((transform.forward * inputZ) * speed * Time.deltaTime);
        transform.Translate((transform.right * inputX) * speed * Time.deltaTime);
    }

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update ()
    {
        float rotationX = cam.transform.localEulerAngles.y + Input.GetAxis ("Mouse X") * sensitivityX;
        rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp (rotationY, minimumY, maximumY);
        
        //Vector3 move = new Vector3(Input.GetAxis ("Horizontal") * walkSpeedStrafe * Time.deltaTime, 0, Input.GetAxis ("Vertical") * walkSpeedForward * Time.deltaTime);
        //transform.Translate(move);
        cam.transform.localEulerAngles = transform.localEulerAngles = (new Vector3(-rotationY, rotationX, 0f));
       // cam.transform.localEulerAngles = new Vector3(transform.localEulerAngles.x * -rotationY, transform.localEulerAngles.y * rotationX, 0f);
        UpdateInputs();
 	    MoveCharacter();
    }
    void FixedUpdate()
    {
        if (Input.GetButtonUp("Jump"))
          rb.AddForce(0, 200, 0);
    }
}
