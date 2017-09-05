using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRound : MonoBehaviour
{
    public Transform center;
    public Vector3 axis = Vector3.right;
    public float radius = 2.0f;
    public float radiusSpeed = 0.5f;
    public float rotationSpeed = 80.0f;

    void Start()
    {
        transform.position = (transform.position - center.position).normalized * radius + center.position;
    }

    void Update()
    {
        transform.RotateAround(center.position, axis, rotationSpeed * Time.deltaTime);
        Vector3 desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
        transform.LookAt(center);
    }

    /*
    private GameObject rotationReference;
    private Transform rotationRef;

    private void Start()
    {
        rotationReference = GameObject.Find("PivotObject");
        rotationRef = rotationReference.GetComponent<Transform>();
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, 20 * Time.deltaTime);
    }
    */
}
