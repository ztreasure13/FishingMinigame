using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowTriggerB : MonoBehaviour
{
    //Script that goes on the mat for the dock mini game...
    //Variables for throwing...
    public RawImage crosshair;

    // Use this for initialization
    void Start()
    {
        crosshair.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Procedures for throwing bobber
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {//Start if
            crosshair.enabled = true;
            BobberThrower.canThrow = true;
        }//End if
    }//End OnTriggerEnter

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {//Start if
            crosshair.enabled = false;
            BobberThrower.canThrow = false;
        }//End if
    }//End OnTriggerEnter
}
