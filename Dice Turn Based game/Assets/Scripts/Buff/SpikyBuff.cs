using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikyBuff : Buff
{
    [SerializeField]
    private int buffAmount;
    
    public override int apply(){
        return buffAmount;
    }

    public override string getBuffType(){
        return "Offensive";
    }
    public override string getDesc(int side){
        return "";
    }
}
