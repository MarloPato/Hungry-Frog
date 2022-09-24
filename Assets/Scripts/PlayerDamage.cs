using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class PlayerDamage : MonoBehaviour
{
    
    public int damage = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    
        
    
    {
       
       
        if (collision.gameObject.CompareTag("Boss") == true)
        {
            
            collision.gameObject.transform.parent.GetComponent<BossState>().DoHarm(damage);
            transform.parent.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            transform.parent.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.parent.GetComponent<PlayerMovement>().moveDirection, 10f),ForceMode2D.Impulse);


        }
    }
}
