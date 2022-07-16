using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : MonoBehaviour
{
    protected string ID;
    public Action(){
        this.ID = "DEFAULT_ACTION";
    }

    public abstract void execute();
    public string getId(){
        return this.ID;
    }
}
