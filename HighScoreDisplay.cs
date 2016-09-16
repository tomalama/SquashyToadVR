using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameState state = GameObject.FindObjectOfType<GameState>();
        Text text = GetComponent<Text>();
        text.text = "High Score: " + state.highScore + " meters";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
