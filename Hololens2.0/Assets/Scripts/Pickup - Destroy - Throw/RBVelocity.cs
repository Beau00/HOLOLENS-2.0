using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBVelocity : MonoBehaviour
{
    private bool isReleased = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (isReleased)
        {
            rb.velocity = rb.velocity / 1.001f;
           // rb.velocity = rb.velocity * 0.9f; goes down in a straight line.
            Debug.Log(rb.velocity);
        }
    }

    public void OnReleaseRB()
    {
        isReleased = true; 
    }

    public void OnPickUp()
    {
        isReleased = false;
    }
}
