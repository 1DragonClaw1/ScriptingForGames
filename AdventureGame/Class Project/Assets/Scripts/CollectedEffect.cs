using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedEffect : MonoBehaviour
{
    public void AnimationComplete()
    {
        Destroy(gameObject);
    }
}
