using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : BaseEnemyScript
{
    [SerializeField]
    private int strikeDamage;
    private void Start() {
        recalcHealth();
    }
    public override string attack(int rolls, int turns)
    {
        strike();
        return "Skeleton uses Strike";
    }

    private void strike(){
        playerScript.hurt(strikeDamage);
    }
    
}
