using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private State _state;

    public State CurrentState { get => _state; set => _state = value; }

    public CharacterController(State state)
    {
        _state = state;
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

    public void JumpRequest()
    {
        _state.Jump(this);
    }
}
