using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveDistance = 5f;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        float newX = startPosition.x + Mathf.PingPong(Time.time * moveSpeed, moveDistance);
        transform.position = new Vector3(newX, startPosition.y, startPosition.z);
    }
}
