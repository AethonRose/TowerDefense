using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    //Asking if Object isPlaceable
    [SerializeField] bool isPlaceable;

    void OnMouseDown() 
    {
        //If Object isPlaceable log out name
        if (isPlaceable)
        {
            Debug.Log(transform.name);
        }
    }
}
