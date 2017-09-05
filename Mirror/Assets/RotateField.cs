using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateField : MonoBehaviour
{

    public float smooth = 1f;
    public float rotationAmount = 180f;
    public float rotationSpeed = 1.0f;
    private Quaternion targetRotation;
    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            targetRotation *= Quaternion.AngleAxis(rotationAmount, Vector3.forward);
        }
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * smooth * Time.deltaTime);
    }
}
