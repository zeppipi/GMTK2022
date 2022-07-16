using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyAttAction : Action
{
    public HeavyAttAction(){
        this.ID = "HeavyAttack";
    }
    public new string getId(){
        return ID;
    }
}
