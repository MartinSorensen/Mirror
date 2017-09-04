using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour {
    private Rigidbody rb;
    public float movementSpeeed = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey("s"))
        {
            rb.MovePosition(transform.position + -transform.forward * Time.deltaTime * movementSpeeed);
        }
        if (Input.GetKey("w"))
        {
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * movementSpeeed);
        }
    }
}
