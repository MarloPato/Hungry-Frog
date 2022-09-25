using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSwitcher : MonoBehaviour
{
    [SerializeField] private MusicController musicController01;
    [SerializeField] private MusicController musicController02;


    void Start()
    {
        gameObject.GetComponent<MusicSwitcher>().musicController02.GetComponentInParent<AudioSource>().enabled = false;
        gameObject.GetComponent<MusicSwitcher>().musicController02.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<MusicSwitcher>().musicController01.GetComponentInParent<AudioSource>().enabled = false;
            gameObject.GetComponent<MusicSwitcher>().musicController02.GetComponentInParent<AudioSource>().enabled = true;
            gameObject.GetComponent<MusicSwitcher>().musicController02.enabled = true;


        }
        
    }
    
       
}
