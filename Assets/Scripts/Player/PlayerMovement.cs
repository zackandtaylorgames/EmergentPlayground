using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Input
    PlayerInputActions inputActions;
    Vector2 movementInput;

    // Movement
    Rigidbody2D rigidBody;
    public float movementSpeed;
    private Vector3 movement;

    void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.PlayerControls.Movement.performed += context => movementInput = context.ReadValue<Vector2>();

        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move(movementInput);
    }

    private void Move(Vector2 direction)
    {
        movement.Set(direction.x, direction.y, 0f);
        movement = movement * movementSpeed * Time.deltaTime;

        rigidBody.MovePosition(transform.position + movement);
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
