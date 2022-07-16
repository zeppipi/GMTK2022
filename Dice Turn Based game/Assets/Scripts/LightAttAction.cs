using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttAction : Action
{
    public LightAttAction(){
        this.ID = "LightAttack";
    }

    public new string getId(){
        return ID;
    }
}
