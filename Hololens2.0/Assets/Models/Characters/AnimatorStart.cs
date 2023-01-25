using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorStart : MonoBehaviour
{
    public List<Material> materialList = new List<Material>();
    public GameObject hat;
    [Header("Chance 0 - 1")]
    public float HatChance = .3f, ItemChance = .2f;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        Invoke("SetBoolStart", Random.Range(0f, 3f));
        Invoke("SetBoolRandom", Random.Range(0f, 5f));

        if (Random.Range(0f, 1f) > HatChance)
        {
            Destroy(hat);
        }
    }

    void SetBoolStart()
    {
        anim.SetBool("Start", true);
    }

    void SetBoolRandom()
    {
        anim.SetBool("StartRandom", true);
    }
}
