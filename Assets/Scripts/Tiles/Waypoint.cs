using UnityEngine;

public class Waypoint : MonoBehaviour
{
    //Asking if Object isPlaceable
    [SerializeField] bool isPlaceable;
    [SerializeField] GameObject ballistaPrefab;

    //If Mouse is pressed down on Object
    void OnMouseDown() 
    {
        //If Object isPlaceable Instantiate ballistaPrefab at transform.position, and ignore rotation
        if (isPlaceable)
        {
            Instantiate(ballistaPrefab, transform.position, Quaternion.identity);
            //Set isPlaceable to false as Tile is now occupied
            isPlaceable = false;
        }
    }
}
