using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public int healthPoints = 2;
    public int initialHealthPoints = 2;
    private GameObject respawnPosition;
    [SerializeField] private GameObject startPosition;
    [SerializeField] private bool useStartPosition = true;
    private PlayerMovement playerMovement;
    
    public int itemAmount = 0;


    void Start()
    {
        healthPoints = initialHealthPoints;
        if (useStartPosition == true)
        {
            gameObject.transform.position = startPosition.transform.position;
        }
        respawnPosition = startPosition;
    }

    void Update()
    {
        
    }

    public void DoHarm(int doHarmByThisMuch)
    {
        healthPoints -= doHarmByThisMuch;
        if (healthPoints <= 0)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        healthPoints = initialHealthPoints;
        gameObject.transform.position = respawnPosition.transform.position;
        
    }

    public void ItemPickup()
    {
        itemAmount++;
    }

    public void ChangeRespawnPosition(GameObject newRespawnPosition)
    {
        respawnPosition = newRespawnPosition;
    }
}
