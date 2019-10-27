using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Ball;
    public Vector3 Offset;

    void Start()
    {
        transform.LookAt(Ball);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Ball.position + Offset;
        transform.LookAt(Ball);
    }
}
