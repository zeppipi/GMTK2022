using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyBuff : Buff
{
    [SerializeField]
    private int buffAmount;

    public override int apply(){
        return buffAmount;
    }

    public override string getDesc(int side){
        return "Any healing moves placed on move " + side + ", heals slightly stronger";
    }

    public override string getBuffType(){
        return "Defensive";
    }
}
