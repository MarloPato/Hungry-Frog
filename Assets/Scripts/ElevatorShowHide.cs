using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorShowHide : MonoBehaviour
{
    [SerializeField] public GameObject BossElevator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        BossElevator.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponentInParent<BossElevatorParent_Boss>().Boss = null)
        {
            print("Nu borde hissen spawna");
            BossElevator.SetActive(true);

        }
    }
}
