using UnityEngine;

public abstract class State : MonoBehaviour
{
    public abstract void PlayLogic(CharacterController charController);
}
