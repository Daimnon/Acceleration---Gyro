using UnityEngine;

public class Walking : State
{
    public override void PlayLogic(CharacterController charController)
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                Debug.Log("Player is still Walking");
                charController.CurrentState = new Walking();
            }
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Player is Ducking");
            charController.CurrentState = new Ducking();
        }

        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Player is Jumping");
            charController.CurrentState = new Jumping();
        }

        else
            Debug.Log("Player is Idle");
    }
}
