using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacles : MonoBehaviour
{
    //private Rigidbody rb;
    public float movementSpeeed = 10.0f;
    private GameObject rotationReference;
    private Transform rotationRef;

    private void Start()
    {
        rotationReference = GameObject.Find("PivotObject");
        rotationRef = rotationReference.GetComponent<Transform>();
    }

    void Update()
    {
        transform.rotation = rotationRef.rotation;
        transform.Translate(-Vector3.right* Time.deltaTime* movementSpeeed);

    }

    /*
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //rb.MovePosition(transform.position + -transform.right * Time.deltaTime * movementSpeeed);
    }
    */
}
