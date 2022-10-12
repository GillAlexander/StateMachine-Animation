using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum CharacterStates
    {
        Idle = 0,
        Walking = 1,
        Running = 2,
        Jumping = 3,
        Attacking = 4,
        Dead = 5
    }


    public CharacterStates currentState;

    #region Singleton
    public static StateMachine Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    private void Start()
    {
        currentState = CharacterStates.Idle;
    }

    public void ChangeCharacterState(CharacterStates newState)
    {
        currentState = newState;
        switch (currentState)
        {
            case CharacterStates.Idle: 
                // Behaviour goes here
                break;
            case CharacterStates.Walking:
                break;
            case CharacterStates.Running:
                break;
            case CharacterStates.Jumping:
                break;
            case CharacterStates.Attacking:
                break;
            case CharacterStates.Dead:
                break;
        }
    }
}
