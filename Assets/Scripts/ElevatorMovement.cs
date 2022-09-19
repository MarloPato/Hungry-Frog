using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private GameObject nextTarget;
    [SerializeField] private List<GameObject> targetPoints;

    private int currentTargetPointIndex;

    void Start()
    {
        if (targetPoints.Count > 0)
        {   
            nextTarget = targetPoints[0];
        }
    }

    void Update()
    {
        if (nextTarget != null)
        {
            MoveToPosition(nextTarget);
        }
    }

    private void MoveToPosition(GameObject moveToTarget)
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, moveToTarget.transform.position, speed * Time.deltaTime);
        if (gameObject.transform.position == moveToTarget.transform.position)
        {
            ChangeTarget();
        }
    }

    private void ChangeTarget()
    {
        currentTargetPointIndex++;


            if (currentTargetPointIndex >= targetPoints.Count)
            {
                currentTargetPointIndex = 0;
            }
        
        nextTarget = targetPoints[currentTargetPointIndex];
    }

    private void OnDrawGizmos()
    {
        foreach (var item in targetPoints)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(item.transform.position, 0.2f);
        }

    }
}
