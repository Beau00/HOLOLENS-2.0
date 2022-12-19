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
        rb.constraints = RigidbodyConstraints.FreezeAll;
        Debug.Log("freeze");
    }
 
    public void OnReleaseRB()
    {
        //rb.constraints = RigidbodyConstraints.None;
    }

    public void OnPickUp()
    {
        rb.constraints = RigidbodyConstraints.None;
    }
}
