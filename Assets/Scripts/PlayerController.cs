using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private bool canJump = false;
    private float JumpSpeed = 10f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float j = Input.GetAxisRaw("Jump");
        Vector3 f = new Vector3(h, 0, v);
        f *= speed;
        rb.AddForce(f);

        if (j > 0.2f && canJump)
        {
            rb.velocity = new Vector3(rb.velocity.x, j * JumpSpeed, rb.velocity.z);
            canJump = false;
        }
    }

     void OnCollisionEnter(Collision collision)
     {
        if (collision.gameObject.tag == "Floor")
        {
            canJump = true;
        }
    }
}
