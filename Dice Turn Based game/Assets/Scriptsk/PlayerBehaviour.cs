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

    //Dice and the set of moves
    [SerializeField, ReadOnly]
    private int dice;


    //Execute the moves
    public override void executeMoves()
    {
        for(int index = 0; index < dice; index++)
        {
            this.actionsList[index].execute();   //This is assuming the actions class has an execute function
        }
    }

    //Player has leveled up
    void levelUp()
    {
        levelSetter(this.level + 1);
    }
    
    //Update is called once per frame
    void Update()
    {
        if (experience > neededExperience)
        {
            levelUp();
        }
    }
}
