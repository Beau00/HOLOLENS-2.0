using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandVelocity : MonoBehaviour
{
    // this script on joints.
    public GameObject jointOne;

    public Vector3 currentpos;
    public Vector3[] positions = new Vector3[5];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // thumb joint
        Transform center = transform; 

        int radius = 1;
        Collider[] hitColliders = Physics.OverlapSphere(center.position, radius);
        foreach (var hitCollider in hitColliders)
        {
            hitCollider.SendMessage("AddDamage");
        }


        //currentpos = transform.position;

        //for (int i = 0; i < 5; i++)
        //{
        //    positions[i] += currentpos;

        //    if(i == 5)
        //    {
        //        Debug.Log("Full");
        //    }
        //}


    }
}
