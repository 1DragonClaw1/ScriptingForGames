using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
	public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
		//Rotate the object around the y axis
		transform.Rotate(xAngle:rotationSpeed * Time.deltaTime, yAngle: 0, zAngle:0); 
    }
}
