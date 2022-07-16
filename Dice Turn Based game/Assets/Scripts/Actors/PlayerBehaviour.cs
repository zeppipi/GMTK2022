using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The class for the player
public class PlayerBehaviour : Actor
{
    //Player specific stats
    [SerializeField, ReadOnly]
    private int experience;     //how much xp have currently
    [SerializeField]
    private int neededExperience;   //how much xp need for a level up

    //Dice
    [SerializeField, ReadOnly]
    private int dice;
    private Dice diceScript;

    //Proccess before the game starts
    void Start()
    {
        diceScript = this.GetComponent<Dice>();
    }
    
    //Execute the moves
    public override void executeMoves()
    {
        dice = diceScript.roll();

        for(int index = 0; index < dice; index++)
        {
            this.actionsList[index].execute();   //This is assuming the actions class has an execute function
        }
    }

    //Player has leveled up
    void levelUp()
    {
        levelSetter(this.level + 1);
        Debug.Log("level up!");
    }
    
    //Update is called once per frame
    public override void Update()
    {
        base.Update();

        if (experience >= neededExperience)
        {
            levelUp();
            this.experience = 0;
        }
    }

    //Player gets xp points
    public void xpAdder(int xp)
    {
        this.experience += xp;
    }
}
