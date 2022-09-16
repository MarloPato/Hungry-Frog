using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

public class KillzoneVisual : MonoBehaviour
{

    public BoxCollider2D BoxCollider2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawCube(new Vector3(BoxCollider2D.offset.x + gameObject.transform.position.x, BoxCollider2D.offset.y + gameObject.transform.position.y), new Vector3 (BoxCollider2D.size.x, BoxCollider2D.size.y));
        
    }
}
