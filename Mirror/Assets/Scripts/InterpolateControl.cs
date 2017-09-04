using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolateControl : MonoBehaviour
{

    Material dissolveM;
    public float dissolveControlSpeeed = 1.0f;
    public float timeToDissolve = 2.0f;
    private float iniTime;

    // Use this for initialization
    void Start()
    {
        dissolveM = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        iniTime += Time.deltaTime / timeToDissolve;
        dissolveM.SetFloat("_InterpolateControl", Mathf.Lerp(1.0f, 0.0f, iniTime));
    }
}
