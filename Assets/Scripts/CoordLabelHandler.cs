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
        DisplayCoordinates();
    }
    
    void Update() 
    {
        if(!Application.isPlaying)
        {
            ChangeObjectName();
            DisplayCoordinates();
        }
    }

    void ChangeObjectName()
    {
        transform.parent.name = coords.ToString();
    }

    void DisplayCoordinates()
    {
        //Swapped x and y cause I rotated the text -90
        coords.x = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);
        coords.y = Mathf.RoundToInt(transform.parent.position.x / -UnityEditor.EditorSnapSettings.move.x);
        
        label.text = $"{coords.x},{coords.y}";
    }

    
}
