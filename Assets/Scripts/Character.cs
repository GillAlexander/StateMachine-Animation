using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int health = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (StateMachine.currentState == StateMachine.CharacterStates.Idle || StateMachine.currentState == StateMachine.CharacterStates.Walking)
            {
                StateMachine.ChangeCharacterState(StateMachine.CharacterStates.Jumping);
            }
        }


        #region Polling
        if (health <= 0)
        {
            StateMachine.ChangeCharacterState(StateMachine.CharacterStates.Dead);
        }
        #endregion
    }

    #region Polling
    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
        if (health <= 0)
        {
            StateMachine.ChangeCharacterState(StateMachine.CharacterStates.Dead);
        }
    }
    #endregion
}
