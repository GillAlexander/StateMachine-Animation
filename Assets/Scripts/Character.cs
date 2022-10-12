using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Character : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    private int health = 100;

    private void Start()
    {
        healthText.SetText($"Health: {health}");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (StateMachine.Instance.currentState == StateMachine.CharacterStates.Idle)
            {
                StateMachine.Instance.ChangeCharacterState(StateMachine.CharacterStates.Jumping);
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(25);
        }

        #region Polling

        healthText.SetText($"Health: {health}");
        if (health <= 0)
        {
            StateMachine.Instance.ChangeCharacterState(StateMachine.CharacterStates.Dead);
        }

        #endregion
    }

    #region Polling

    public void TakeDamage(int damageTaken)
    {
        healthText.SetText($"Health: {health}");
        health -= damageTaken;
        if (health <= 0)
        {
            StateMachine.Instance.ChangeCharacterState(StateMachine.CharacterStates.Dead);
        }
    }

    #endregion
}
