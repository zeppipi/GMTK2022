using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolySide : Buff
{
    [SerializeField]
    private int buffAmount;
    public HolySide(){
        this.buffType = "Defensive";
    }
    private void Awake() {
        this.buffType = "Defensive";
    }
    private void Start() {
        this.buffType = "Defensive";
        this.color = Color.blue;
    }
    public override int apply(){
        return buffAmount;
    }

    public override string getBuffType(){
        return "Defensive";
    }
}
