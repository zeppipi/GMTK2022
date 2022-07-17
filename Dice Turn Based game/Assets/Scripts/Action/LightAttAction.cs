using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that does a quick light attack
public class LightAttAction : Action
{

    [SerializeField]
    private int damage;

    private PlayerBehaviour player;
    private BaseEnemyScript enemy;

    public LightAttAction(){
        this.ID = "LightAttack";
    }
    private void Start() {
        this.actionType = "Offensive";
    }
    public override string execute(int delay, int position, int rolls){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();

        // Only attack the first enemy in the array
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0].GetComponent<BaseEnemyScript>();

        enemy.hurt(damage + extraBuff);
        resetExtraBuff();
        return "uses Light Attack";
    }
    public new string getId(){
        return ID;
    }

    public void setDamage(int damage){
        this.damage = damage;
    }
}
