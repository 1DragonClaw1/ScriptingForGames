using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 500f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
}
