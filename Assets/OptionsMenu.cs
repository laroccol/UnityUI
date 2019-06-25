using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System;

public class OptionsMenu : MonoBehaviour
{
    public Image background;
    public Image middleColumn;
    public Text newsText;
    public Toggle colorModeToggle;
    public AudioMixer audioMixer;

    private Color displayColor = UnityEngine.Color.white;
    private Color middleColumnColor = new Color(0.0f, 0.663f, 1.0f, 0.392f);
    private bool darkMode;

    public void ColorModeChange(bool newValue)
    {
        if (newValue)
        {
            darkMode = true;
            background.color = UnityEngine.Color.black;
            middleColumn.color = UnityEngine.Color.black;
            newsText.color = UnityEngine.Color.white;
        }
        else
        {
            darkMode = false;
            background.color = displayColor;
            middleColumn.color = middleColumnColor;
            newsText.color = UnityEngine.Color.black;
        }
    }

    public void Setvolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void ChangeColorOptions(Int32 option)
    {
        switch(option)
        {
            case 0:
                displayColor = UnityEngine.Color.white;
                middleColumnColor = new Color(0.0f, 0.663f, 1.0f, 0.392f);
                break;
            case 1:
                displayColor = UnityEngine.Color.red;
                middleColumnColor = new Color(1.0f, 0.0f, 0.0f, 0.392f);
                break;
            case 2:
                displayColor = UnityEngine.Color.green;
                middleColumnColor = new Color(0.0f, 1.0f, 0.0f, 0.392f);
                break;
        }

        if (!darkMode)
        {
            background.color = displayColor;
            middleColumn.color = middleColumnColor;
        }
    }

}
