using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : State
{
    public override void Stand(CharacterController charController)
    {
        Debug.Log("Player is Idle");
        charController.CurrentState = new Idle();
    }

    public override void Move(CharacterController charController)
    {
        Debug.Log("Player is Walking");
        charController.CurrentState = new Walking();
    }

    public override void Crouch(CharacterController charController)
    {
        Debug.Log("Player is Ducking");

        charController.CurrentState = new Ducking();
    }

    public override void Dive(CharacterController charController)
    {
        Debug.Log("Player is Diving");
        charController.CurrentState = new Diving();
    }

    public override void Jump(CharacterController charController)
    {
        Debug.Log("Player is Jumping");
        charController.CurrentState = new Jumping();
    }
}
