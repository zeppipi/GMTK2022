using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttAction : Action
{

    [SerializeField]
    private int damage;

    private PlayerBehaviour player;
    private BaseEnemyScript enemy;

    public LightAttAction(){
        this.ID = "LightAttack";
    }

    public override void execute(int delay, int position, int rolls){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();

        // Only attack the first enemy in the array
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0].GetComponent<BaseEnemyScript>();

        enemy.hurt(damage);

        Debug.Log("ACTION: light Attack");
    }
    public new string getId(){
        return ID;
    }
}
