using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementHandler : MonoBehaviour
{
    //Create list of waypoints for enemy in inspector
    [SerializeField] List<Waypoint> waypoints = new List<Waypoint>();
    [SerializeField] [Range(0,5)] float speed = 1f;

    void Start() 
    {
        Debug.Log("Start");
        //Starts Coroutine
        StartCoroutine(FollowWaypoints());
        Debug.Log("Start Moving");
    }

    IEnumerator FollowWaypoints()
    {
        //Loop through each waypoint in waypoints List
        foreach (Waypoint waypoint in waypoints)
        {
            //Set current & new Positions
            Vector3 currentPosition = transform.position;
            Vector3 newPosition = waypoint.transform.position;
            //Default movementPercent to 0 for Lerp in while loop
            float movementPercent = 0f;

            transform.LookAt(newPosition);
            //execute while movementPercent < 1
            while (movementPercent < 1f)
            {
                //update movementPercent with speed * Time.deltatime
                movementPercent += (speed * Time.deltaTime);
                //lineral interpolate enemy position from current to newPosition, using movementPercent to move enemy
                transform.position = Vector3.Lerp(currentPosition, newPosition, movementPercent);

                //waits untill Lerp is completed
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
