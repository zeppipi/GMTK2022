using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassin : BaseEnemyScript
{
    [SerializeField]
    private int backStabDamage;
    [SerializeField]
    private int stabDamage;
    public override string attack(int rolls, int turns){
        if(rolls == 1){
            backStab();
            return "Assassin use Back Stab";
        } else {
            stab();
            return "Assassin use stab";
        }
        
    }

    private void backStab(){
        playerScript.hurt(backStabDamage);
    }

    private void stab(){
        playerScript.hurt(stabDamage);
    }

}
