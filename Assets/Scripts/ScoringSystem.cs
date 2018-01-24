using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour {

    private BirdController player;
    private AudioSource[] music;
    private AudioSource score;

	void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdController>();
        music = GameObject.FindGameObjectWithTag("Music").GetComponents<AudioSource>();
        score = music[2];
	}
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            player.AddScore();
            score.Play();
        }
    }
}
