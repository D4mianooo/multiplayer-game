using System;
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

public class Coin : NetworkBehaviour {
    private Transform _target;

    private void OnTriggerEnter(Collider other) {
        _target = other.transform;
    }
    private void LateUpdate() {
        if(!_target) return;
        transform.parent.position = _target.position + Vector3.up;
    }
}
