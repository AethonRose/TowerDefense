using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]
public class CoordLabelHandler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coords = new Vector2Int();

    void Awake()
    {
        label = GetComponent<TextMeshPro>();
        //Run on Awake/Start otherwise coords wont be displayed while game is running
        DisplayCoordinates();
    }
    
    void Update() 
    {
        //Update in Editor
        //If Application !Playing update the ObjectName and DisplayCoordiantes
        if(!Application.isPlaying)
        {
            ChangeObjectName();
            DisplayCoordinates();
        }
    }

    void ChangeObjectName()
    {
        //Changes the ObjectName to its set coordinates
        transform.parent.name = coords.ToString();
    }

    void DisplayCoordinates()
    {
        //Set each tiles coords to their respective locations, /by EditorSnapSettings to get numbers at 1 digit. Basically /by 10
        //Swapped x and y cause I rotated the text -90
        coords.x = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        coords.y = Mathf.RoundToInt(transform.parent.position.x / -UnityEditor.EditorSnapSettings.move.x);
        //Set label text to its coords
        label.text = $"{coords.x},{coords.y}";
    }

    
}
