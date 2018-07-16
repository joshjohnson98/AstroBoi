using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

    //public PlayerControls pc;

    public Text ScoreText;
	// Use this for initialization
	void Start () {
        //timer = GetComponent<Timer>();
        ScoreText.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}