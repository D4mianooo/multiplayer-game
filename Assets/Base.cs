using System;
using UnityEngine;

public class Base : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.name);
    }
}
