using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAnimationScript : MonoBehaviour
{
    public GameObject airPushing; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FanPause()
    {
        gameObject.GetComponent<Animator>().enabled = false;
        airPushing.SetActive(false);
    }
    void FanContinue()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        airPushing.SetActive(true);
    }

}
