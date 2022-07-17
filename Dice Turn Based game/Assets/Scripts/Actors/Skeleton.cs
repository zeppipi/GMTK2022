using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : BaseEnemyScript
{
    [SerializeField]
    private float strikeDamage;

    public override string attack(int rolls, int turns)
    {
        strike();
        return "Skeleton uses Strike";
    }

    private void strike(){
        playerScript.hurt((int) (baseDamage * strikeDamage));
    }
    
}
