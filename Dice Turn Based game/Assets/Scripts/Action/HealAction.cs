using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealAction : Action
{
    [SerializeField]
    private PlayerBehaviour player;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();

    }
    public HealAction(){
        this.ID = "Heal";
    }

    public override void execute(int delay, int position, int rolls){
        player.healthAdder(50);
        Debug.Log("ACTION: Player Healed");
    }

    public new string getId(){
        return this.ID;
    }
}
