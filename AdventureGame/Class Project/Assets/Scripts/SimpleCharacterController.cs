using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    public ManaContainer manaData;
    public SimpleImageBehavior image;
    public HealthContainer healthContainer;
    public GameObject youWin;

    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 velocity;
    private Vector3 movementVector = Vector3.zero;

    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    // Update is called once per frame
    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnZAxis();
        ManageOtherInput();

        if (transform.position.y < -8f || healthContainer.healthData.value <= 0)
        {
            Die();
        }
    }

    private void MoveCharacter()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Set horizontal movement
        Vector3 move = new Vector3(horizontalInput * moveSpeed, 0f, 0f);

        // Jumping
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Small push downward to stay grounded
        }

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }

        // Apply gravity
        velocity.y += gravity * Time.deltaTime;

        // Combine horizontal move with vertical velocity
        move.y = velocity.y;

        // Move character
        controller.Move(move * Time.deltaTime);
    }

    private void KeepCharacterOnZAxis()
    {
        Vector3 currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }

    public void ManageOtherInput()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            manaData.ReduceMana(-0.1f);
            image.UpdateWithFloatData();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goal")
        {
            youWin.SetActive(true);
        }
    }

    private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
