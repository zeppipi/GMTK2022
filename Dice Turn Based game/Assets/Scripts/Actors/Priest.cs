using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : BaseEnemyScript
{
    [SerializeField]
    private float healNumber;

    [SerializeField]
    private float holyAttackDamage;


    public override string attack(int rolls, int turns){
        if(rolls % 2 == 0){
            purify();
            holyAttack();
            return "Priest heals and attacks you";
        } else {
            holyAttack();
            return "Priest use Holy Attack";
        }
    }
    
    private void purify(){
        this.healthAdder((int) (baseHeal * healNumber));
    }

    private void holyAttack(){
        playerScript.hurt((int) (baseDamage * holyAttackDamage));
    }
}
