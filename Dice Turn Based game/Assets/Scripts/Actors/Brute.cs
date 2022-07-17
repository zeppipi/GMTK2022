using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : BaseEnemyScript
{

    [SerializeField]
    private int strikeDamage;

    [SerializeField]
    private int heavyStrikeDamage;
 
    public override string attack(int rolls){
        // Every 6 Rolls hit a heavy attack on the player
        if (rolls == 6){
            heavyStrike();
            return "Brute use Heavy Strike";
        } else {
            strike();
            return "Brute use Strike";
        }
        
    }

    private void strike(){
        playerScript.hurt(strikeDamage);
    }

    private void heavyStrike(){
        playerScript.hurt(heavyStrikeDamage);

    }

    



    
}
