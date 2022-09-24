

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CaveEntranceToNextLevel : MonoBehaviour
{
    [SerializeField] int levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {

                GameObserver.SaveApplesToMemory(collision.GetComponent<PlayerState>().itemAmount);
                SceneManager.LoadScene(levelToLoad);
            
        }
    }
}
