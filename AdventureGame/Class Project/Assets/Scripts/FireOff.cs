using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOff : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        anim.SetTrigger("FireOff");
        GetComponent<SphereCollider>().enabled = false;
    }
}
