using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private State _state;

    [SerializeField]
    private bool _isGrounded;

    [SerializeField]
    private float _airTimeCounter = 0;

    public State CurrentState { get => _state; set => _state = value; }
    public bool IsGrounded { get => _isGrounded; set => _isGrounded = value; }
    public float AirTimeCounter { get => _airTimeCounter; set => _airTimeCounter = value; }
    
    public CharacterController(State state)
    {
        _state = state;
    }

    private void Update()
    {
        if (_airTimeCounter > 0)
            _airTimeCounter -= Time.deltaTime;

        else if (_airTimeCounter == 0)
            _isGrounded = true;
    }
    public void StandRequest()
    {
        _state.Stand(this);
    }

    public void MoveRequest()
    {
        _state.Move(this);
    }

    public void CrouchRequest()
    {
        _state.Crouch(this);
    }

    public void DiveRequest()
    {
        _state.Dive(this);
    }

    public void JumpRequest(bool isGrounded)
    {
        _state.Jump(this);
    }
}
