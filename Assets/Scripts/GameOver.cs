using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {

    private GameObject playAgainButton;
    private GameObject menuButton;
    private Image gameOverImage;
    private DisplayScore score;
    private AudioSource[] sounds;
    private AudioSource wingSound;
    private BestScore bestScore;


    void Start ()
    {
        gameOverImage = GameObject.FindGameObjectWithTag("GameOver").GetComponent<Image>();
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<DisplayScore>();
        playAgainButton = GameObject.FindGameObjectWithTag("PlayAgain") as GameObject;
        menuButton = GameObject.FindGameObjectWithTag("Exit") as GameObject;
        sounds = GameObject.FindGameObjectWithTag("Music").GetComponents<AudioSource>() as AudioSource[];
        bestScore = GameObject.FindGameObjectWithTag("Settings").GetComponent<BestScore>();
        wingSound = sounds[1];
        DisableButtons();            
    }

    public void DisplayGameOver()
    {
        gameOverImage.enabled = true;
        playAgainButton.SetActive(true);
        menuButton.SetActive(true);

        bestScore.Calculate();

    }

    public void IsOver()
    {
        DisableSounds();
        score.Disable();
        DisplayGameOver();
        Time.timeScale = 0;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void DisableSounds()
    {
        wingSound.mute = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void DisableButtons()
    {
        playAgainButton.SetActive(false);
        menuButton.SetActive(false);
    }
}
