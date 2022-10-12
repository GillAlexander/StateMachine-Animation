using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellShooter : MonoBehaviour
{
    public enum SpellType
    {
        Fire,
        Ice,
        Arcane,
        Elemental
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    private void CastSpell(SpellType spellType)
    {

    }
}
