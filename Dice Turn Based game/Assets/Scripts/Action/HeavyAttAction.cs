using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeavyAttAction : Action
{   
    [SerializeField]
    private PlayerBehaviour player;

    [SerializeField]
    private BaseEnemyScript enemy;

    public HeavyAttAction(){
        this.ID = "HeavyAttack";
    }

    private void Start() {

    }

    public override void execute(int delay, int position, int rolls){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();

        // Only attack the first enemy in the array
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0].GetComponent<BaseEnemyScript>();

        if(rolls > delay + position){
            enemy.hurt(25);
            Debug.Log("ACTION: Heavy Attack");
        } else {
            Debug.Log("ACTION: Heavy Attack Failed");
        }

        
    }
    public new string getId(){
        return ID;
    }

    public override int getDelay()
    {
        return 1;
    }
}
