using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public GameObject Score;
    public GameObject Score1;
    public GameObject Score2;

    public GameObject pauseButton;

    string gameId = "4230831";

    void Start()
    {
        Advertisement.Initialize(gameId);
    }


    public void PauseMenu()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        Score.SetActive(false);
        Score1.SetActive(false);
        Score2.SetActive(false);
        pauseButton.SetActive(false);
    }

    public void CloseMenu()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Score.SetActive(true);
        Score1.SetActive(true);
        Score2.SetActive(true);
        pauseButton.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;

        int counter = PlayerPrefs.GetInt("CliclkCount", 0);
        counter++;
        if (counter % 8 == 0)
        {
            Debug.Log("Restart");

            this.ReklamGoster();
        }
        PlayerPrefs.SetInt("CliclkCount", counter);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReklamGoster()
    {
        Advertisement.Show();
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
