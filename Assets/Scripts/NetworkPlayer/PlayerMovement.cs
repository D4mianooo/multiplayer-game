using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NetworkPlayer {
    public class PlayerMovement : NetworkBehaviour {

        private NetworkVariable<Vector3> _spawnPosition = new NetworkVariable<Vector3>();
        public float speed = 5f;
        private Vector2 _movementInput;

        private InputSystemActions _inputSystemActions;

        private void Awake() {
            _inputSystemActions = new InputSystemActions();
        }

        private void OnEnable() {
            _inputSystemActions.Player.Enable();

            _inputSystemActions.Player.Move.performed += OnMovePerformed;
            _inputSystemActions.Player.Move.canceled += OnMoveCanceled;
        }

        private void OnDisable() {
            _inputSystemActions.Player.Disable();

            _inputSystemActions.Player.Move.performed -= OnMovePerformed;
            _inputSystemActions.Player.Move.canceled -= OnMoveCanceled;
        }

        private void Update() {
            if(!IsSpawned) return;
            if(!IsOwner) return;
            Vector3 direction = new Vector3(_movementInput.x, 0, _movementInput.y);
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }

        private void OnMovePerformed(InputAction.CallbackContext context) {
            _movementInput = context.ReadValue<Vector2>();
        }

        private void OnMoveCanceled(InputAction.CallbackContext context) {
            _movementInput = Vector2.zero;
        }

        public override void OnNetworkSpawn() {
            Debug.Log($"OnNetworkSpawn");
            // transform.position = _spawnPosition.Value;
            base.OnNetworkSpawn();
        }

    }
}