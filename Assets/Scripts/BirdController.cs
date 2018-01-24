using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {
           
    public int score = 0;
    public bool isAlive = true;

    private Rigidbody2D bird;
    private AudioSource[] sounds;
    private AudioSource hit;
    private AudioSource wings;
    private GameOver game;


    void Awake ()
    {
        Time.timeScale = 1;
        bird = GetComponent<Rigidbody2D>();
        sounds = GameObject.FindGameObjectWithTag("Music").GetComponents<AudioSource>();
        game = GetComponent<GameOver>();
        wings = sounds[1];
        hit = sounds[3];
	}
	
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            bird.velocity = new Vector2(0, 5);
            wings.Play();
        }
	}
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe" || collision.gameObject.tag == "Ground")
        {
            hit.Play();
            game.IsOver();
            isAlive = false;
            //Destroy(gameObject);
            //Add fall down animation
        }
    }

    public void AddScore()
    {
        score += 1;
    }
}
