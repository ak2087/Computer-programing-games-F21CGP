using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    public GameObject lift
    ;
    void OnTriggerEnter()
    {
        lift.GetComponent<Animation>().Play("EnemyLift");
    }
}
