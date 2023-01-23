using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class On_Obj_Pickup : MonoBehaviour
{
    private bool pickedUp = false;
    private bool scriptsAdded = false;
    private Rigidbody _rigidbody;

    public void OnObjectPickUp()
    {
        pickedUp = true;
        
        if (pickedUp && !scriptsAdded)
        {
            _rigidbody = gameObject.AddComponent<Rigidbody>();
            gameObject.AddComponent<ThrowableTest>();
            gameObject.GetComponent<ObjectManipulator>().OnManipulationEnded.AddListener(AddThrowFunction);
            scriptsAdded = true;
        }
        _rigidbody.isKinematic = true;

    }

    public void AddThrowFunction (ManipulationEventData test)
    {
        gameObject.GetComponent<ThrowableTest>().AddVelocity();
        Debug.Log("Throw added.");
    }

    
}
