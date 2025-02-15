using UnityEngine;

public class LoopExamples : MonoBehaviour
{
    // Array for demonstrating foreach loop
	public int[] playerScores = { 10, 20, 30, 40 };

	private int count = 0;

    private void Start()
    {
        // For Loop: Move objects forward 10 times
		Debug.Log(message: "For Loop: Moving objects");
		for (int i = 0; i < 10; i++)
		{
			Debug.Log(message: "Object " + i + " moved forward");
		}
	
		// While loop: Keep moving until count is greater than 5
		Debug.Log(message: "While Loop: Moving while count < 5");
		while (count < 5)
		{
			Debug.Log(message: "Count: " + count);
			count++;
		}

		// Do-while loop: Always runs at least once
		Debug.Log(message: "Do-While Loop: Moving at least once");
		do
		{
			Debug.Log(message: "Do-while loop executed, count = " + count);
			count++;
		} while (count < 7);

		// Foreach loop: Go thtough the array of player scores
		Debug.Log(message: "Foreach Loop: Displaying player scores");
		foreach (int score in playerScores)
		{
			Debug.Log(message: "Player score: " + score);
		}
    }
}
