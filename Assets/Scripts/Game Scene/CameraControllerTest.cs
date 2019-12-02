using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerTest : MonoBehaviour
{
    public GameObject player;
    public float horizontalInput;


    public float smoothFactor = 15f;                                                                //Not really sure what this is
    private Vector3 cameraOffset;
    public Transform PlayerTransform;
    Vector3 initialOffset = new Vector3(0f, 2f, -1.5f);
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");


        Quaternion camTurnAngle = Quaternion.AngleAxis(horizontalInput * 2.19f, Vector3.up);     //Scalar Value for camera rotation
        cameraOffset = camTurnAngle * cameraOffset;                                             //Actual distance to be from player

        Vector3 newPos = PlayerTransform.position + cameraOffset;                               //Desired position of Camera

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);          //This is what rotates the camera around player

        transform.LookAt(PlayerTransform);  
        transform.Rotate(-40, 0, 0);                                                          //Camera Looks downward 40 degrees
    }

    private void Update()
    {
        
    }
}
