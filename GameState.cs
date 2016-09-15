using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
    
    public bool IsGameOver { get; set; }
    
    private Canvas canvas;
    
    public void ResetGame()
    {
        Application.LoadLevel("Main");
    }

    public void BackToMenu()
    {
        Application.LoadLevel("SplashScreen");
    }
    
    // Use this for initialization
    void Start()
    {
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
}
