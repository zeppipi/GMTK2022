using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttAction : Action
{
    public LightAttAction(){
        this.ID = "LightAttack";
    }


    public override void execute(){

    }
    public new string getId(){
        return ID;
    }
}
