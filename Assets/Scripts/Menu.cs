using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {

    public Image flappybirdImage;
    public Image getReady;
    public Image playButton;
    public Image bird;
    public Image arrow;
    public Image tap;
    public Image tapRight;
    public Image tapLeft;
    public GameObject exitButton;
    public Text bestScore;
    public Text bestScoreValue;

	void Start ()
    {
        DisableGetReady();
        EnableMainMenu();
        UpdateBestScore();
	}

    public void PlayGame()
    {
        Time.timeScale = 1;
        DisableUI();
        EnableGetReady();
        Invoke("LoadGame", 1);
    }

    public void DisableUI()
    {
        flappybirdImage.enabled = false;
        playButton.enabled = false;
        exitButton.SetActive(false);
        bestScore.enabled = false;
        bestScoreValue.enabled = false;
    }

    public void EnableGetReady()
    {
        getReady.enabled = true;
        bird.enabled = true;
        arrow.enabled = true;
        tap.enabled = true;
        tapRight.enabled = true;
        tapLeft.enabled = true;

    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void DisableGetReady()
    {
        getReady.enabled = false;
        bird.enabled = false;
        arrow.enabled = false;
        tap.enabled = false;
        tapLeft.enabled = false;
        tapRight.enabled = false;
    }

    public void EnableMainMenu()
    {
        flappybirdImage.enabled = true;
        playButton.enabled = true;
    }

    public void DisableMainMenu()
    {
        playButton.enabled = false;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void UpdateBestScore()
    {
        bestScoreValue.text = PlayerPrefs.GetInt("bestScore").ToString();
    }
}
