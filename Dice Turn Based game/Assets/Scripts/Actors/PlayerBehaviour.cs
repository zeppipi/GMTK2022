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

    //Animator
    [SerializeField]
    private Animator playerAnimator;

    //Proccess before the game starts
    void Start()
    {
        diceScript = this.GetComponent<Dice>();
        playerAnimator = this.GetComponent<Animator>();
    }
    
    //Execute the moves
    public override void executeMoves()
    {
        //Roll dice
        dice = diceScript.roll();

        //Play Moves
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

    //Play animtion
    public void playAnimation()
    {
        playerAnimator.Play("Base Layer.AttackAnimation");
    }

    //Player gets xp points
    public void xpAdder(int xp)
    {
        this.experience += xp;
    }
    
    public int getHealth(){
        return health;
    }

}
