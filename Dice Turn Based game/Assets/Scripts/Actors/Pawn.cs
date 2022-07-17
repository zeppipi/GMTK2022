using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : BaseEnemyScript
{
    [SerializeField]
    private int lightAttackDamage;

    [SerializeField]
    private float increasePercentage;
 
    public override string attack(int rolls, int turns){
        if (rolls >= 3){
            Throw((int) (lightAttackDamage * (increasePercentage * (rolls - 3))));
            return "Pawn use Improved Light Attack";
        } else {
            Throw(0);
            return "Pawn use Light Attack";
        }
    }

    private void Throw(int extraDamage){
        playerScript.hurt(lightAttackDamage + extraDamage);
    }
}
