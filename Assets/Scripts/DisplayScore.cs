using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

    private Text score;
    private BirdController player;  

	void Awake ()
    {
        score = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdController>();
        score.enabled = true;
	}
	
	void Update ()
    {
        score.text = player.score.ToString();
	}

    public void Disable()
    {
        score.enabled = false;
    }
}
