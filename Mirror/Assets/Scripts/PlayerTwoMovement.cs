using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeeed = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey("down"))
        {
            rb.MovePosition(transform.position + -transform.forward * Time.deltaTime * movementSpeeed);
        }
        if (Input.GetKey("up"))
        {
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * movementSpeeed);
        }
    }
}
