using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] List<Waypoint> waypoints = new List<Waypoint>();

    void Start() 
    {
        PrintWaypointName();
    }

    void PrintWaypointName()
    {
        foreach (Waypoint waypoint in waypoints)
        {
            Debug.Log(waypoint.name);
        }
    }
}
