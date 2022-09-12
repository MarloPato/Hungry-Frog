using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObserver : MonoBehaviour
{
    public static void SaveApplesToMemory(int Amount)
    {
        PlayerPrefs.SetInt("AppleAmount", PlayerPrefs.GetInt("AppleAmount") + Amount);
    }
}
