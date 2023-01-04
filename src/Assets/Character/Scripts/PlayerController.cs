using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float JumpForce;
    private bool GroundedPlayer;
    
    private Rigidbody2D _playerRigidbody2D;
    private PlayerInputMap _playerInput;

    private void Awake()
    {
        _playerInput = new PlayerInputMap();
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    public void Update()
    {
        var moveValue = _playerInput.PlayerTouch.Move.ReadValue<Vector2>();

        moveValue = new Vector2(moveValue.x * Speed, _playerRigidbody2D.velocity.y);

        _playerRigidbody2D.velocity = moveValue;

        if (_playerInput.PlayerTouch.Jump.triggered)
            Jump();
    }

    private void Jump()
    {
        _playerRigidbody2D.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
    }
}
