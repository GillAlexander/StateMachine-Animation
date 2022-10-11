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
    public enum EnemyStates
    {
        Idle,
        Patrolling,
        Alerted,
        Attacking,
        Fleeing,
        Dead
    }


    public CharacterStates currentState;

    #region Singleton
    public StateMachine Instance = null;
    private void Start()
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

    public static void ChangeCharacterState(CharacterStates state)
    {
        switch (state)
        {
            case CharacterStates.Idle:
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
