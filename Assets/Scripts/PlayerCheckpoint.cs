using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickUpClip;
    
    
    private Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        audioSource.enabled = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            collision.GetComponent<PlayerState>().ChangeRespawnPosition(gameObject);
            animator.SetTrigger("Captured");
            audioSource.enabled = true;
            audioSource.PlayOneShot(pickUpClip);
            audioSource = null;


        }
        
        
            
            
        
    }
   
   


}
