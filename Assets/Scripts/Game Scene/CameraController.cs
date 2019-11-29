using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    private Vector3 offset = new Vector3(0, 2, -1.5f);
    public Transform pivot;
    // Start is called before the first frame update
    void Start()
    {
        pivot.transform.position = target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
