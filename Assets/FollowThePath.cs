using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    public Transform[] WayPoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int WayPointIndex = 0;

    public bool moveAllowed = false;

    private void Start()
    {
        transform.position = WayPoints[WayPointIndex].transform.position;
    }

    private void Update()
    {
        if (moveAllowed)
            Move();
    }

    private void Move()
    {
        if (WayPointIndex <= WayPoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, WayPoints[WayPointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == WayPoints[WayPointIndex].transform.position)
            {
                WayPointIndex += 1;
            }
        }
    }


}
