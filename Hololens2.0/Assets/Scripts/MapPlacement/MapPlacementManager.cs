using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPlacementManager : MonoBehaviour
{
    public GameObject mapGizmos;
    public GameObject mapParent;

    public void SetMap()
    {
        mapGizmos.SetActive(false);
        Instantiate(mapParent, mapGizmos.transform.position, mapGizmos.transform.rotation);

        mapParent.transform.localScale = mapGizmos.transform.localScale;
    }
}
