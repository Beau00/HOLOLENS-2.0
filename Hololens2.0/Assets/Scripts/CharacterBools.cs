using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBools : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        Debug.Log("Shitting");
        animator.SetBool("IsWalking", false);
        animator.SetBool("Panic", false);


        animator.SetBool("Start", true);
        animator.SetBool("IsSitting", true);
    }
 

    public void PanicTrue()
    {
        animator.SetBool("IsSitting", false);
        animator.SetBool("Panic", false);

        animator.SetBool("Start", true);
        animator.SetBool("IsWalking", true);
        animator.SetBool("Panic", true);
        Debug.Log("Panik");  
    }

    public void WalkingTrue()
    {
        animator.SetBool("IsWalking", false);
        animator.SetBool("Panic", false);
        animator.SetBool("IsSitting", false);
        animator.SetBool("Start", true);
        Debug.Log("Wolk");
       
    }
    
}
