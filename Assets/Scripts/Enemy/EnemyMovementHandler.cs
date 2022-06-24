using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementHandler : MonoBehaviour
{
    //Create list of waypoint for enemy in inspector
    [SerializeField] List<Waypoint> waypoints = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)] float speed = 1f;

    void Start() 
    {
        Debug.Log("Start");
        //Start Coroutine
        StartCoroutine(FollowWaypoints());
        Debug.Log("Start Moving");
    }

    IEnumerator FollowWaypoints()
    {
        //Loop through each waypoint in waypoints List
        foreach (Waypoint waypoint in waypoints)
        {
            //Set current & newPositions
            Vector3 currentPosition = transform.position;
            Vector3 newPosition = waypoint.transform.position;
            //Default movementPercent to 0%
            float movementPercent = 0f;

            transform.LookAt(newPosition);

            //Execute while movementPercent < 1
            while (movementPercent < 1f)
            {
                //Update movementPercent by adding (speed * Time.deltatime)
                movementPercent += (speed * Time.deltaTime);
                //Lerp enemy position from current to newPosition using movementPercent to move enemy
                transform.position = Vector3.Lerp(currentPosition, newPosition, movementPercent);
                //Waits until Lerp is completed
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
