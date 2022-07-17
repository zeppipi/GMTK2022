using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Action abstract class, includes all the features that every action has
public abstract class Action : MonoBehaviour
{
    //Action's ID
    protected string ID;

    // Action type, can only be either Offensive or Defensive
    protected string actionType;

    //The action's delay
    protected int delay = 0;

    protected int extraBuff = 0;
    
    public Action(){
        this.ID = "DEFAULT_ACTION";
    }

    public abstract string execute(int delay, int position, int rolls);
    
    public string getId(){
        return this.ID;
    }

    public virtual int getDelay(){
        return delay;
    }

    public void setExtraBuff(int heal){
        this.extraBuff = heal;
    }

    public void addExtraBuff(int heal){
        this.extraBuff += heal;
    }

    public void resetExtraBuff(){
        this.extraBuff = 0;
    }

    public string getActionType(){
        return actionType;
    }

}
