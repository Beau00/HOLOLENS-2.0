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
            gameObject.AddComponent<Throwable>();

            _rigidbody.useGravity = false;

            gameObject.GetComponent<ObjectManipulator>().OnManipulationEnded.AddListener(AddThrowFunction);

            scriptsAdded = true;
        }
       

    }

    public void AddThrowFunction (ManipulationEventData test)
    {
        _rigidbody.useGravity = true;
        gameObject.GetComponent<Throwable>().Throw();
    }

    
}
