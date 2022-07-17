using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolySide : Buff
{
    [SerializeField]
    private int healAmount;

    public override int apply(){
        target = GameObject.FindGameObjectWithTag("Player");
        PlayerBehaviour player = target.GetComponent<PlayerBehaviour>();
        player.healthAdder(healAmount);
        return 0;
    }
    public override string getBuffType(){
        return "NotBuff";
    }

    
}
