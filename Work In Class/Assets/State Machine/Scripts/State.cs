using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public abstract void Stand(CharacterController charController);
    public abstract void Move(CharacterController charController);
    public abstract void Crouch(CharacterController charController);
    public abstract void Dive(CharacterController charController);
    public abstract void Jump(CharacterController charController);
}
