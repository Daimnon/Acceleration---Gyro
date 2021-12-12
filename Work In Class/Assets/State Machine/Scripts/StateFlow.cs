using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFlow : MonoBehaviour
{
    CharacterController _charController = new CharacterController(new Idle());

    private void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _charController.CrouchRequest();
            
            if (Input.GetKeyUp(KeyCode.DownArrow))
                _charController.StandRequest();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            _charController.JumpRequest(_charController.IsGrounded);

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _charController.DiveRequest();

                if (Input.GetKeyUp(KeyCode.DownArrow))
                    _charController.StandRequest();
            }
        }
    }
}
