using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolySide : Buff
{
    [SerializeField]
    private int buffAmount;
    
    private void Start() {
        this.buffType = "Defensive";
    }
    public override int apply(){
        return buffAmount;
    }
}
