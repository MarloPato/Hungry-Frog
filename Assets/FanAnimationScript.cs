using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FanAnimationScript : MonoBehaviour
{
    public GameObject airPushing;
    public bool Active = true;
    private int BinaryActivation = 1;
    public bool TimerActivated = false;
    private float timer;
    public float duration = 5;
    public bool TimerBased = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (TimerBased == true)
        {
            Timer();
            FanState();
        }
     }


    void FanPause()
    {
        gameObject.GetComponent<Animator>().enabled = false;
        airPushing.SetActive(false);
    }
    void FanContinue()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        airPushing.SetActive(true);
    }
    void Timer()
    {
        timer += Time.deltaTime;
        if (timer >= duration)
        {
            timer = 0f;
            BinaryActivation *= -1;

        }
    }

    private bool BinaryReader()
    {
        if (BinaryActivation > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void FanState()
    {
        if (BinaryReader() == true)
        {
            FanContinue();
        }
        else
        {
            FanPause();
        }
    }

}
