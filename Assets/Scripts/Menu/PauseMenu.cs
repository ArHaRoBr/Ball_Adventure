using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject settingsMenu;

    public Toggle musicToggle;
    public Toggle soundToggle;

    public AudioMixer audioMixer;

    public GameObject player;
    bool onPause = false;

    public void PauseGame()
    {
        if (!onPause)
        {
            pauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        player.SetActive(false);
        player.GetComponent<PlayerMoving>().enabled = false;
        Time.timeScale = 0f;
        onPause = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        player.SetActive(true);
        player.GetComponent<PlayerMoving>().enabled = true;
        Time.timeScale = 1f;
        onPause = false;
    }

    public void TurnMusic()
    {
        if (musicToggle.isOn == false) audioMixer.SetFloat("MusicVol", -80);
        else audioMixer.SetFloat("MusicVol", 0);
    }
    public void TurnSound()
    {
        if (soundToggle.isOn == false) audioMixer.SetFloat("SoundVol", -80);
        else audioMixer.SetFloat("SoundVol", 0);
    }

}
