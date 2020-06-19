using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


    public class MyClimbingScript : MonoBehaviour
{
    // a reference to the action
    public SteamVR_Action_Boolean ClimbGrip;
    // a reference to the hand
    public SteamVR_Input_Sources handType;
    //reference to the sphere
    public GameObject Sphere;

   // Vector3 handPosition;

    

    // Start is called before the first frame update
    void Start()
    {
        ClimbGrip.AddOnStateDownListener(GripDown, handType);
        ClimbGrip.AddOnStateUpListener(GripUp, handType);
    }

    public void GripUp(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Grip is up");
        Sphere.GetComponent<MeshRenderer>().enabled = false;
    }
    public void GripDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        Debug.Log("Grip is down");
        Sphere.GetComponent<MeshRenderer>().enabled = true;

        //handPosition = 
    }

}
