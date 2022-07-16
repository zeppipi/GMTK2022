using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Action abstract class, includes all the features that every action has
public abstract class Action : MonoBehaviour
{
    //Action's ID
    protected string ID;

    //The action's delay
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
