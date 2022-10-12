using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellShooter : MonoBehaviour
{
    public enum SpellType
    {
        Fire = 0,
        Ice = 1,
        Arcane = 2,
        Elemental = 3
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
