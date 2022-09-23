using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BossHealth : MonoBehaviour
{
    public BossState bossState;
    int bossMaxHealth;
    

    public Slider slider;


    private void Start()
    {
        bossMaxHealth = bossState.bossMaxHealth;
        slider = gameObject.GetComponent<Slider>();
        
        
    }

    private void Update()
    {
        slider.value = bossState.bossHealth;

    }

}