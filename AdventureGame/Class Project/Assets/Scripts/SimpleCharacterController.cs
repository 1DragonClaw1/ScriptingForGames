using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
	public float moveSpeed = 5f;
	public float jumpForce = 8f;
	public float gravity = -9.81f;

	private CharacterController controller;
	private Transform thisTransform;
	private Vector3 velocity;
	private Vector3 movementVector = Vector3.zero;

    // Start is called before the first frame update
    private void Start()
    {
		//Cache references to components
        controller = GetComponent<CharacterController>();
		thisTransform = transform;
    }

    // Update is called once per frame
     private void Update()
    {
		MoveCharacter();
		ApplyGravity();
		KeepCharacterOnZAxis();
    }

	private void MoveCharacter()
	{
		movementVector.x = Input.GetAxis("Horizontal");
		movementVector.x *= (moveSpeed * Time.deltaTime);

		// Jumping
		if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
		}
		controller.Move(movementVector);

	}

	private void ApplyGravity()
	{
		if (!controller.isGrounded)
		{
            velocity.y += gravity * Time.deltaTime;
		}
		else
		{
			velocity.y = 0f; // Reset velocity when grounded
		}
		
		// Apply the velocity to the controller
		controller.Move(velocity *  Time.deltaTime);
	}
	private void KeepCharacterOnZAxis()
	{
		// Use cached transform reference and optimize vector creation
		Vector3 currentPosition = thisTransform.position;
		currentPosition.z = 0f;
		thisTransform.position = currentPosition;
	}
}
