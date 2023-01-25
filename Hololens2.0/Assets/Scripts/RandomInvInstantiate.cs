using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInvInstantiate : MonoBehaviour
{
    public GameObject[] clouds;

    public void RandomInstantiate()
    {
        GameObject instantiated = Instantiate(clouds[Random.Range(0, clouds.Length)], transform.position, transform.rotation);
        instantiated.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
