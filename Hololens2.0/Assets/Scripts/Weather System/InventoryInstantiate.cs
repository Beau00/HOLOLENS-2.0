using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInstantiate : MonoBehaviour
{
    public GameObject objToInstantiate;

    public void ButtonClickedInstantiate()
    {
        GameObject instantiated = Instantiate(objToInstantiate, transform.position, transform.rotation);
        instantiated.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
