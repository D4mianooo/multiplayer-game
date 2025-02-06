using System;
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

public class Coin : NetworkBehaviour {
    private Transform _target;
    private bool _locked;
    
    private void OnTriggerEnter(Collider other) {
        if(_locked) return;
        _target = other.transform;
        _locked = true;
    }

    private void LateUpdate() {
        if(!_target) return;
        transform.parent.position = _target.position + Vector3.up;
    }
    
}
