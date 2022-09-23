using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossKillbox : MonoBehaviour
{
    GameObject gameObjectToKill;
    
    private void Start()
    {
        gameObjectToKill = gameObject.transform.parent.gameObject;
    }

    private void Update()
    {
        if (gameObject.transform.parent.GetComponent<BossState>().bossHealth <= 0)
        {
            gameObject.GetComponentInParent<BossMovement>().KillMe();
        }
    }


}

