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

    public string getDesc(int side){
        return "";
    }

    public override string getBuffType(){
        return "Defensive";
    }
}
