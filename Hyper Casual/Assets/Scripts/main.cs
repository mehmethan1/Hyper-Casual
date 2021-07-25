using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public void ReturnToGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

    public void Restart()
    {
        Time.timeScale = 1f;

        int counter = PlayerPrefs.GetInt("CliclkCount", 0);
        counter++;
        if (counter % 5 == 0)
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
}
