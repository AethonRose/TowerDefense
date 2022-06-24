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
        //Set ballistaBolts to ParticleSystem of Child (BallistaTopMesh ParticleSystem on Ballista prefab)
        ParticleSystem ballistaBolts = GetComponentInChildren<ParticleSystem>();

        //Set weapon to LookAt target
        weapon.LookAt(target);

        //if no more targets can be found stop emitting ballistaBolts
        if (target == null)
        {
            ballistaBolts.Stop();
        }
    }
}
