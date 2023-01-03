using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D playerRigidbody2D { get; private set; }
    public FixedJoystick playerJoystick;

    private void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        playerRigidbody2D.velocity = Vector3.right * playerJoystick.Horizontal * Speed;
    }
}
