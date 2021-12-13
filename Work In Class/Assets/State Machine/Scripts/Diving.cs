using UnityEngine;

public class Diving : State
{
    public override void PlayLogic(CharacterController charController)
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                Debug.Log("Player is moving while Diving");
            }
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Player stopped Diving and is now Idle");
            charController.CurrentState = new Idle();
        }

        else
            Debug.Log("Player is still Diving");
    }
}
