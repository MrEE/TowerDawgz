using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    private CharacterController characterController;
    public bool canClimb = false;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
        Debug.Log(direction);

        if (canClimb)
        {
            //ClimbingStuff(Hand.transform.localPosition);
        }
        else
        {
            //Walking on Ground
            //characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
            
            //Flying
            characterController.Move(speed * Time.deltaTime * direction);
        }
    }

    // Move the player relative to the local position of the hand controller.
    void ClimbingStuff(Vector3 gripPos)
    {
        characterController.transform.position += gripPos;
    }
}
