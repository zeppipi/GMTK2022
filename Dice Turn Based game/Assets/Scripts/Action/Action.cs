using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : MonoBehaviour
{
    protected string ID;

    protected int delay = 0;
    public Action(){
        this.ID = "DEFAULT_ACTION";
    }

    public abstract void execute(int delay, int position, int rolls);
    public string getId(){
        return this.ID;
    }

    public virtual int getDelay(){
        return delay;
    }
}
