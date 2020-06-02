using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climber : MonoBehaviour
{

    public GameObject Body;

    public SteamVR_TrackedObject controller;

    public Vector3 prevPos;
    public bool canGrip;

    void Start()
    {
        prevPos = controller.transform.localPosition;
    }

    void Update()
    {
        var device = SteamVR_Controller.Input((int)controller.index);
        if (canGrip && device.GetTouch(SteamVR_Controller.ButtonMask.Grip))
        {
            Body.transform.position += (prevPos - controller.transform.localPosition);
        }
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
