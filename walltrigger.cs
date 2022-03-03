using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walltrigger : MonoBehaviour
{
    public GameObject lift;
    
    public GameObject wall
     ;
    void OnTriggerEnter()
    {
        lift.GetComponent<Animation>().Play("wallanim");
        wall.GetComponent<Animation>().Play("wallanim1");
    }
}
