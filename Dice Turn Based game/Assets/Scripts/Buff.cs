using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff : MonoBehaviour
{
    protected GameObject target;
    
    protected string buffType;

    public Color color = Color.gray;

    public string getBuffType(){
        return buffType;
    }

    public abstract int apply();
}
