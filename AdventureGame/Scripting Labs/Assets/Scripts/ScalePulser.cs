
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float pulseSpeed = 2f;
	public float maxScale = 1.5f;
	public float minScale = 0.5f;

    void Update()
    {
        //Scale the object up and down smoothly
		float scale = Mathf.PingPong(Time.time * pulseSpeed, length:maxScale - minScale) + minScale;
		transform.localScale = new Vector3(x:scale, y:scale, z:scale);
    }
}
