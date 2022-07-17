using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//A class with the action that heals who casts it
public class HealAction : Action
{
    //Set how much healing you do
    [SerializeField]
    private int heal;

    private PlayerBehaviour player;

    //Get the reference of the script
    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
        this.actionType = "Defensive";
    }
    public HealAction(){
        this.ID = "Heal";
    }

    //Execute
    public override string execute(int delay, int position, int rolls){
        player.healthAdder(heal + extraBuff);
        resetExtraBuff();
        return " Heals by " + heal;
    }

    public new string getId(){
        return this.ID;
    }

    //Getter and setter for the healing
    public void setHeal(int heal)
    {
        this.heal = heal;
    }

    public int getHeal()
    {
        return heal;
    }

}
