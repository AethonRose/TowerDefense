using UnityEngine;

public class FindTarget : MonoBehaviour
{
    //Set to weapon piece meant to move
    [SerializeField] Transform weapon;
    Transform target;

    void Start() 
    {
        //Set weapons target to first object found with an EnemyMovementHandler script
        target = FindObjectOfType<EnemyMovementHandler>().transform;
    }

    void Update() 
    {
        //Call LookAtTarget
        LookAtTarget();
    }

    void LookAtTarget()
    {
        //Set weapon to LookAt target
        weapon.LookAt(target);
    }
}
