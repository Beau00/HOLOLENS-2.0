using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{

    // The radius in which the script will detect nearby rigidbodies
    public float detectionRadius = 10f;

    // The force of the tornado
    public float force = 10f;

   
    // Update is called once per frame
    void Update()
    {
        // Use the OverlapSphere method to detect rigidbodies within the detection radius
        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius);

        // Loop through all detected colliders
        foreach (Collider col in colliders)
        {
            // Check if the collider has a rigidbody attached
            if (col.attachedRigidbody != null)
            {
                // Add force to the rigidbody in the direction of the tornado's center
                col.attachedRigidbody.AddForce((transform.position - col.transform.position) * force);
            }
        }
    }

    // Draw the detection radius in the Scene view for debugging purposes
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
