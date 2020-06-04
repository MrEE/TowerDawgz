using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Climber : MonoBehaviour
{

    public GameObject Body;

    // public SteamVR_Controller controller;

    public Hand controller;

    public Vector3 prevPos;
    public bool canGrip;

    void Start()
    {
        controller = GetComponent<Hand>();

        prevPos = controller.transform.localPosition;
    }

    void Update()
    {
        /* NOTE: 
         * This isn't working because the "SteamVR_Controller" is depricated since the upgrade to SteamVR 2.0
         * Must figure out how to make this work for SteamVR 2.0
         */
        
        if (canGrip)
        {
            Body.transform.position += (prevPos - controller.transform.localPosition);
        }

        

        Body.transform.position += (prevPos - controller.transform.localPosition);
    }

    void OnTriggerEnter()
    {
        canGrip = true;
    }

    void OnTriggerExit()
    {
        canGrip = false;
    }
    
    
}
