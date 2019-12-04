﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{

    public GameObject settingsButton;
    public GameObject resumeButton;
    public GameObject quitButton;
    public GameObject backButton;
    public GameObject audioText;
    public GameObject slider1;
    public GameObject slider2;
    public GameObject slider3;
    public GameObject masterText;
    public GameObject musicText;
    public GameObject sfxText;



    public void OnSettingsPress()
    {
        settingsButton.SetActive(false);
        resumeButton.SetActive(false);
        quitButton.SetActive(false);
        backButton.SetActive(true);
        audioText.SetActive(true);
        slider1.SetActive(true);
        slider2.SetActive(true);
        slider3.SetActive(true);
        musicText.SetActive(true);
        masterText.SetActive(true);
        sfxText.SetActive(true);
    }

    public void BackButton()
    {
        settingsButton.SetActive(true);
        resumeButton.SetActive(true);
        quitButton.SetActive(true);
        backButton.SetActive(false);
        audioText.SetActive(false);
        slider1.SetActive(false);
        slider2.SetActive(false);
        slider3.SetActive(false);
        musicText.SetActive(false);
        masterText.SetActive(false);
        sfxText.SetActive(false);
    }
}
