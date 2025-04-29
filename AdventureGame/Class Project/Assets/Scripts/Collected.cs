using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{
    private Animator anim;
    public GameObject pop;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayAnimation();
        }
    }

    public void PlayAnimation()
    {
        Instantiate(pop, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
}
