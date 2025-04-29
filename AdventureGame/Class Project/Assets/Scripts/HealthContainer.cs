using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthData;

    private void Start()
    {
        healthData.SetValue(1);
    }

    public void ReduceHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }
    
    public void SetHealth(float amount)
    {
        healthData.SetValue(amount);
    }
}
