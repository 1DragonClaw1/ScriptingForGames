using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        print("collected");
        anim.SetTrigger("Collected");
        GetComponent<SphereCollider>().enabled = false;
    }
    
}
