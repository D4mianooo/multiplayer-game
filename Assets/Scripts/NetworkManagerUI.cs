using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour {
    [SerializeField] private Button _hostBtn;
    [SerializeField] private Button _serverBtn;
    [SerializeField] private Button _clientBtn;

    void OnEnable() {
        _hostBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();
        });

        _serverBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartServer();
        });

        _clientBtn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
        });
    }
}
