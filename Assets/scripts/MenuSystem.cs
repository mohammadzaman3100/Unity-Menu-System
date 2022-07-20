using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuSystem : MonoBehaviour
{
    public GameObject optionsPanel;
    public AudioMixer audioMixer;

    public void StartGame()
    {
        SceneManager.LoadScene("New Scene");
        Debug.Log("Starting game Scene 'new Scene'");
    }

    public void SetGraphicsQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        Debug.Log("Setting graphics quality to: " + qualityIndex);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        //AudioListener.volume = volume;
        //Debug.Log(volume);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting the game");
    }
}