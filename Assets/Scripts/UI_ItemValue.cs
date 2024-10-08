using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ItemValue : MonoBehaviour
{
    private Text textComponent;
    private PlayerState playerState;

    void Start()
    {
       playerState = GameObject.Find("Player").GetComponent<PlayerState>();
        textComponent = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        textComponent.text = playerState.itemAmount.ToString();
    }
}
