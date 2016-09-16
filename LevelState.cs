using UnityEngine;
using System.Collections;

public class LevelState : MonoBehaviour {

    private Canvas canvas;
    private bool _IsGameOver = false;

    public bool IsGameOver
    {
        get { return _IsGameOver; }
        set
        {
            if (value)
            {
                SetHighScore();
            }
            _IsGameOver = value;
        }
    }

    private void SetHighScore()
    {
        GameState state = GameObject.FindObjectOfType<GameState>();
        Player player = GameObject.FindObjectOfType<Player>();
        int score = Mathf.FloorToInt(player.transform.position.z);
        state.UpdateHighScore(score);
    }

    // Use this for initialization
    void Start()
    {
        IsGameOver = false;
        canvas = FindObjectOfType<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsGameOver == true)
        {
            canvas.enabled = true;
        }
    }

    public void ResetGame()
    {
        SceneLoader loader = GameObject.FindObjectOfType<SceneLoader>();
        loader.LoadLevelByOffset(0);
    }

    public void BackToMenu()
    {
        SceneLoader loader = GameObject.FindObjectOfType<SceneLoader>();
        loader.LoadLevelByOffset(-1);
    }
}
