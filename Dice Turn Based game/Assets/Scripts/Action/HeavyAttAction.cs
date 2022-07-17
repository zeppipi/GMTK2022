using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A heavy attack class, release extra damage with a delay
public class HeavyAttAction : Action
{   
    //Set damage and delay
    [SerializeField]
    private int damage;
    [SerializeField]
    private int delay;

    private PlayerBehaviour player;
    private BaseEnemyScript enemy;

    public HeavyAttAction(){
        this.ID = "HeavyAttack";
    }

    private void Start() {
        this.actionType = "Offensive";

    }

    //Execute
    public override string execute(int delay, int position, int rolls){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();

        // Only attack the first enemy in the array
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0].GetComponent<BaseEnemyScript>();

        if(rolls > delay + position){
            enemy.hurt(damage + extraBuff);
            resetExtraBuff();
            return "uses Heavy Attack";
        } else {
            return "tried to use Heavy Attack, but failed";
        }

        
    }
    public new string getId(){
        return ID;
    }

    //Getters and setters for the damage
    public int getDamage()
    {
        return this.damage;
    }

    public void setDamage(int damage)
    {
        this.damage = damage;
    }
    
    //Getters and setters for the delay
    public override int getDelay()
    {
        return delay;
    }

    public void setDelay(int delay)
    {
        this.delay = delay;
    }
}
