using System;
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

public class Coin : NetworkBehaviour, IPickable {
    public Player OwnedBy { get; set; }

    public void Pickup(GameObject parent) {
        if(!parent) return;
        NetworkObject.TrySetParent(parent.transform);
        transform.SetLocalPositionAndRotation(Vector3.up, Quaternion.identity);
    }
}
