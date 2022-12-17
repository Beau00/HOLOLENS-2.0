using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelection : MonoBehaviour
{

    public void SelectMainMap()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectDesertMap()
    {
        SceneManager.LoadScene(2);
    }
}
