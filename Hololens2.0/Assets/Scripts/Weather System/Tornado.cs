using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    // The radius of the tornado's "suction zone"
    public float radius = 10.0f;

    // The strength of the force applied to rigidbodies within the suction zone
    public float strength = 10.0f;

    // The speed at which rigidbodies spin around the tornado
    public float spinSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // Get all colliders within the tornado's suction zone
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        // Loop through each collider
        foreach (Collider collider in colliders)
        {
            // Make sure the collider is a rigidbody
            if (collider.attachedRigidbody)
            {
                // Apply a force to the rigidbody to make it spin around the tornado
                collider.attachedRigidbody.AddForce((transform.position - collider.transform.position) * strength, ForceMode.Acceleration);

                // Rotate the rigidbody around the tornado
                collider.attachedRigidbody.transform.RotateAround(transform.position, transform.up, spinSpeed * Time.deltaTime);
            }
        }
    }
}
