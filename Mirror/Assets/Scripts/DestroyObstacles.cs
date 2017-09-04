using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacles"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Player"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
