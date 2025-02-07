using System;
using Unity.Netcode;
using UnityEngine;

public class Player : NetworkBehaviour {
    public int PlayerID { get; private set; }

    public override void OnNetworkSpawn() {
        PlayerID++;
        Debug.Log($"{nameof(Player)} with id: {PlayerID} spawned");
        base.OnNetworkSpawn();
    }

    private void OnTriggerEnter(Collider other) {
        if (!other.TryGetComponent(out Coin coin)) return;
        if (coin.OwnedBy == this) return;
        coin.OwnedBy = this;
        coin.GetComponent<IPickable>().Pickup(gameObject);
    }
}
