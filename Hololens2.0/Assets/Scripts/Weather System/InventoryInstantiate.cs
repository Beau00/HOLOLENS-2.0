using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInstantiate : MonoBehaviour
{
    public GameObject objToInstantiate;

    public void ButtonClickedInstantiate()
    {
        Instantiate(objToInstantiate, transform.position, transform.rotation);
    }
}
