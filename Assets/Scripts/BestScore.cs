using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScore : MonoBehaviour {

    private int bestScore;
    private BirdController player;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdController>();
        bestScore = PlayerPrefs.GetInt("bestScore");
	}
	
    public void Calculate()
    {
        if (player.score > bestScore)
            bestScore = player.score;

        PlayerPrefs.SetInt("bestScore", bestScore);

    }
}
