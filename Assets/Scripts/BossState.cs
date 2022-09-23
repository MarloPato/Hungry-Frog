using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossState : MonoBehaviour
{
    public int bossHealth = 3;
    public int bossMaxHealth = 3;
    // Start is called before the first frame update
    void Start()
    {
        bossHealth = bossMaxHealth;
    }
    private void Update()
    {
        if (bossHealth < 2)
        {
            GetComponent<BossMovement>().speed = 3;
        }
    }
    public void DoHarm(int doHarmByThisMuch)
    {
        
        bossHealth = bossHealth - 1;
      
    }
}
 
