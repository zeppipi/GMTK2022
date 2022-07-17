using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseEnemyScript
{
    [SerializeField]
    private int strikeDamage;
    public override string attack(int rolls, int turns)
    {
        if (turns % 2 != 0){
            strike();
            return "Goblin Attacks you";
        } else {
            return "Goblin Does Nothing";
        }
    }
    private void strike(){
        playerScript.hurt(strikeDamage);
    }
}
