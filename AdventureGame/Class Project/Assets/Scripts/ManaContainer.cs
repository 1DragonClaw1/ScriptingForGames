using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaContainer : MonoBehaviour
{
    public SimpleFloatData manaData;

    public void ReduceMana(float amount)
    {
        manaData.UpdateValue(amount);
        print(manaData.value);
    }
    public void AddMana(float amount)
    {
        manaData.UpdateValue(amount);
        print(manaData.value);
    }
}
