using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{


    [SerializeField] private KeyCode jumpKey = KeyCode.Space;
    [SerializeField] private KeyCode crouchKey = KeyCode.LeftControl;



    public static Vector2 Movement;
    public static bool JumpWasPressed;
    public static bool JumpIsHeld;
    public static bool JumpWasReleased;
    public static bool RunIsHeld;



    // Update is called once per frame
    private void Update()
    {
        Movement =  new Vector2( Input.GetAxisRaw("Horizontal"),0);
        JumpWasPressed = Input.GetKeyDown(jumpKey);
        JumpIsHeld = Input.GetKey(jumpKey);

        JumpWasReleased = Input.GetKeyUp(jumpKey);

        RunIsHeld = Input.GetKey(crouchKey);

    }
}
