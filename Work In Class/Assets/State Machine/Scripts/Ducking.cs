using UnityEngine;

public class Ducking : State
{
    public override void PlayLogic(CharacterController charController)
    {

        if (Input.GetKey(KeyCode.DownArrow))
            Debug.Log("Player is still Ducking");

        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Debug.Log("Player stopped Ducking and is now Idle");
            charController.CurrentState = new Idle();
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                Debug.Log("Player is moving while Ducking");
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Player is Jumping Higher");
            charController.CurrentState = new Jumping();
        }

        else
            Debug.Log("Player is Idle");
    }
}
