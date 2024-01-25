using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    [SerializeField]
    private Unit[] units;
    
    public void SetIdle()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = Unit.UnitState.Idle;
        }
    }
    public void SetMove()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = Unit.UnitState.Move;
        }
    }
    public void SetAttack()
    {
        for (int i = 0; i < units.Length; i++)
        {
            units[i].State = Unit.UnitState.Attack;
        }
    }
}
