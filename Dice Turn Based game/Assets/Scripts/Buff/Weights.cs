using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weights : Buff
{
    private Dice dice;
    private void Awake() {
        target = GameObject.FindGameObjectWithTag("Dice");
        dice = target.GetComponent<Dice>();
    }
    
    public override int apply(){
        // dice.addChances(chances);
        return 1;
    }

    public override string getBuffType(){
        return "Defensive";
    }
    public override string getDesc(int side){
        return "";
    }
}
