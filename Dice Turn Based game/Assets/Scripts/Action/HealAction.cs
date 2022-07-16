using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealAction : Action
{
    public HealAction(){
        this.ID = "Heal";
    }
    private void Update() {
        Debug.Log("HEAAALLLL");
    }
    public new string getId(){
        return this.ID;
    }
}
