using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_DisplayApplesCollected : MonoBehaviour
{
    [SerializeField] private Text textComponent;

    void Start()
    {
        textComponent.text = "Total Apples Collected: " + PlayerPrefs.GetInt("AppleAmount");
    }
}
