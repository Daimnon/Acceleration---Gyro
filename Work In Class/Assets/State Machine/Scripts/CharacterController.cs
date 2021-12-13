using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private State _state;
    public State CurrentState { get => _state; set => _state = value; }
    
    public CharacterController(State state)
    {
        _state = state;
    }

    public void StartStateMachine()
    {
        _state.PlayLogic(this);
    }
}
