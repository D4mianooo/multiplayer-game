using System;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Base : NetworkBehaviour {
    [SerializeField] private int _ownerID;

    private void OnTriggerEnter(Collider other) {
        if (!other.TryGetComponent<Coin>(out Coin coin)) return;
        if (coin.OwnedBy.PlayerID != _ownerID) return;
        coin.GetComponent<IPickable>().Pickup(gameObject);
    }
}
