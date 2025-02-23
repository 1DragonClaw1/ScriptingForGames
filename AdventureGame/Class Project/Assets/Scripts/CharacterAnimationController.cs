using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
	private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Cache the Animator component attached to Character
		animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        HandleAnimations();
    }
	
	private void HandleAnimations()
	{
		//Handle running and idling
		if (Input.GetAxis("Horizontal") != 0)
		{
			animator.SetBool("Run", true);
		}
		else
		{
			animator.SetBool("Run", false);
		}

		// Handle Hit
		if (Input.GetKeyDown(KeyCode.H))
		{
			animator.SetTrigger("Hit");
		}

		// Handle Fall
		if (Input.GetKeyDown(KeyCode.F))
		{
			animator.SetTrigger("Fall");
		}

		// Handle Jumping
		if (Input.GetKey(KeyCode.Space))
		{
			animator.SetBool("Jump", true);
		}
		else
		{
			animator.SetBool("Jump", false);
		}

		//// Handle Double Jumping
		if (Input.GetKeyDown(KeyCode.C))
		{
			animator.SetTrigger("Double Jump");
		}

		// Handle Wall Jumping
		if (Input.GetKeyDown(KeyCode.W))
		{
			animator.SetTrigger("WallJump");
		}
	
	}

	public void Hit()
	{
        animator.SetTrigger("Hit");
    }
}
