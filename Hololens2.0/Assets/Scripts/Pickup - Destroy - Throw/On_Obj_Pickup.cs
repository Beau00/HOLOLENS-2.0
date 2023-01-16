using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Obj_Pickup : MonoBehaviour
{
    private bool pickedUp = false;
    private bool scriptsAdded = false;

    public void OnObjectPickUp()
    {
        pickedUp = true;
        
        if (pickedUp && !scriptsAdded)
        {
            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().mass = 0.1f;
            gameObject.AddComponent<Throwable>();
            scriptsAdded = true;
        }
       

    }
}
