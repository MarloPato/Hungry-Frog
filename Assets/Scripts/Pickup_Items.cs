using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_Items : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private float timeBeforeDeletion;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip pickUpClip;
    private float timer = 0f;
    private bool removeGameObject;
    private bool canPickupCoin = true;

    private void Update()
    {
        if (removeGameObject == true)
        {
            timer += Time.deltaTime;
            if (timer >= timeBeforeDeletion)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            if (canPickupCoin == true)
            {
                collision.GetComponent<PlayerState>().ItemPickup();
                spriteRenderer.sprite = null;
                animator.enabled = false;
                particles.Play();
                removeGameObject = true;
                canPickupCoin = false;
                audioSource.pitch = Random.Range(0.9f, 1.1f);
                audioSource.PlayOneShot(pickUpClip);
            }
        }
    }
}
