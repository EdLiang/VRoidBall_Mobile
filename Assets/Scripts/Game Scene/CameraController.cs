using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 2, -1.5f);
    private float horizontalInput;

    public float RotationSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.position = player.transform.position + offset;

        //transform.Rotate(0, horizontalInput, 0);

        Quaternion camTurnAngle = Quaternion.AngleAxis(horizontalInput * RotationSpeed, Vector3.up);
    }
}
