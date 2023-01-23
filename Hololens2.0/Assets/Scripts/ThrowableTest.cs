using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowableTest : MonoBehaviour
{

    Vector3[] positions = new Vector3[4];
    private float timer = 0;
    private int positionCount;
    private Rigidbody rb;
    private float speed;
    private Vector3 dir;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.1) //4 keer per seconden
        {
            timer = 0;
            positions[3] = positions[2];
            positions[2] = positions[1];
            positions[1] = positions[0];
            positions[0] = transform.position;
            if (positionCount == 4)
            {
                //Calculate direction & speed
                dir = ((positions[0] - positions[1]) + (positions[1] - positions[2]) + (positions[2] - positions[3])) / 3;

                dir.Normalize();

                speed = Vector3.Distance(positions[0], positions[1]) + 
                        Vector3.Distance(positions[1], positions[2]) + 
                        Vector3.Distance(positions[2], positions[3]) / 3;
               
            }
            else
            {
                positionCount++;
            }
        }
    }

    // Update is called once per frame
    public void AddVelocity()
    {
        rb.isKinematic = false;

        Debug.Log(dir);
        Debug.Log(speed);

        rb.velocity = dir * (speed * 4);

    }
}
