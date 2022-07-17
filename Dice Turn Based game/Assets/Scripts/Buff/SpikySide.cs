using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikySide : Buff
{
    [SerializeField]
    private int damageAmount;

    public override int apply(){
        target = GameObject.FindGameObjectsWithTag("Enemy")[0];
        BaseEnemyScript enemy = target.GetComponent<BaseEnemyScript>();
        enemy.hurt(damageAmount);
        return 0;
    }
    public override string getBuffType(){
        return "NotBuff";
    }
    public override string getDesc(int side){
        return "";
    }
}
