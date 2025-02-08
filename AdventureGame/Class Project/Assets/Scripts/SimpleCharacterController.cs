using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
	public float moveSpeed = 5f;
	private CharacterController controller;
	private Transform thisTransform;
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
		KeepCharacterOnZAxis();
    }

	private void MoveCharacter()
	{
		movementVector.x = Input.GetAxis("Horizontal");
		movementVector *= (moveSpeed * Time.deltaTime);
		controller.Move(movementVector);
	}

	private void KeepCharacterOnZAxis()
	{
		// Use cached transform reference and optimize vector creation
		Vector3 currentPosition = thisTransform.position;
		currentPosition.z = 0f;
		thisTransform.position = currentPosition;
	}
}
