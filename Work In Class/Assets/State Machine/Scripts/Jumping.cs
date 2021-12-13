using UnityEngine;

public class Jumping : State
{
    public override void PlayLogic(CharacterController charController)
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
                Debug.Log("Player is moving a bit in the air");
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Player is Diving");
            charController.CurrentState = new Diving();
        }

        else
            Debug.Log("Player is Idle");
    }
}
