using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public Vector2 range = new Vector2(2, 4);
    public float speed = 0.5f;
    public Vector3 direction = Vector3.right;
    private Vector3 startPosition;

    private bool handInteraction = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (!handInteraction)
        {
            Vector3 newPosition = startPosition + direction * Mathf.PingPong(Time.time * speed, range.y - range.x) + range.x * direction;
            transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime);
        }
        
    }

}
