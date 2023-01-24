using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class GoBac : MonoBehaviour
{
        public void Ongobac()
        {
            SceneManager.LoadScene(0);
        }
}
