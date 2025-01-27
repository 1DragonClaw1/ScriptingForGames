using UnityEngine;

public class ObjectMover : MonoBehaviour
{
	public float speed = 2f;
	public float distance = 3f;

    // Update is called once per frame
    void Update()
    {
		//Move the object back and forth along the x axis
		float x = Mathf.PingPong(t:Time.time * speed, length:distance);
		transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
