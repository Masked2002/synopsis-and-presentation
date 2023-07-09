using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuController : MonoBehaviour
{
    [Header("Volume Settings")]

    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultvolume = 1.0f;

    [SerializeField] private GameObject confirmationPrompt = null;

    [Header("Levels to Load")]
    public string _newGameLevel;



    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);
    }

        public void ExitButton()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void VolumeApply()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBox());
    }

    public IEnumerator ConfirmationBox()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
