using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") == true)
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }

        if (collision.CompareTag("Boss") == true)
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}
