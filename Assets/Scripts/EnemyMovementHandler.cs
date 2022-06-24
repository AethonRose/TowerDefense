using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementHandler : MonoBehaviour
{
    [SerializeField] List<Waypoint> waypoints = new List<Waypoint>();
    [SerializeField] float coroutineWaitTime = 1f;

    void Start() 
    {
        Debug.Log("Start");
        StartCoroutine(FollowWaypoints());
        Debug.Log("Start Moving");
    }

    IEnumerator FollowWaypoints()
    {
        foreach (Waypoint waypoint in waypoints)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(coroutineWaitTime);
        }
    }
}
