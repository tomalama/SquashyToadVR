using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

    public int highScore;

	void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateHighScore(int currentScore)
    {
        if (currentScore > highScore)
        {
            highScore = currentScore;
        }
    }
}
