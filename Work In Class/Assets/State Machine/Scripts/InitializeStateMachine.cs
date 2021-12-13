using UnityEngine;

public class InitializeStateMachine : MonoBehaviour
{
    CharacterController _charController = new CharacterController(new Idle());

    private void Update()
    {
        _charController.StartStateMachine();
    }
}
