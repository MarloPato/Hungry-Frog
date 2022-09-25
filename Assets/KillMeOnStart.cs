using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMeOnStart : MonoBehaviour
{

    [SerializeField] private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
