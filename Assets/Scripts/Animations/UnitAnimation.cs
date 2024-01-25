using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    private Animator anim;
    private Unit unit;
    
    private void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsAttack", false);
        switch (u.State)
        {
            case Unit.UnitState.Idle:
                anim.SetBool("IsIdle", true);
                break;
            case Unit.UnitState.Move:
                anim.SetBool("IsMove", true);
                break;
            case Unit.UnitState.Attack:
                anim.SetBool("IsAttack", true);
                break;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        unit = GetComponent<Unit>(); 
    }

    // Update is called once per frame
    void Update()
    {
        ChooseAnimation(unit);
    }
}
