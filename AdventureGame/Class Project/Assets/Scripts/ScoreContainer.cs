using UnityEngine;

public class ScoreContainer : MonoBehaviour
{
    public SimpleIntData scoreData;

    private void Start()
    {
        scoreData.SetValue(0);
    }

    public void IncreaseScore(int amount)
    {
        scoreData.UpdateValue(amount);
    }

    public void SetScore(int amount)
    {
        scoreData.SetValue(amount);
    }
}
