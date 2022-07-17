using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff : MonoBehaviour
{
    protected GameObject target;
    
    protected string buffType;

    public Color color = Color.gray;

    public abstract string getBuffType();

    public abstract int apply();

    public abstract string getDesc(int side);
}
