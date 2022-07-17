using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract class for the actors, which includes the players and enemies
abstract public class Actor : MonoBehaviour
{
    //Description stat
    private Description actorDescription;
    
    //Basic stats
    [SerializeField]
    protected int health;

    [SerializeField]
    protected int maxHealth;

    [SerializeField]
    protected int level;

    //Actor's action(s)
    [SerializeField]
    protected Actions[] actionsList;

    //Execute the move(s)
    public virtual void executeMoves(){ }

    //What should be done when this actor dies?
    public virtual void Dies(){ }

    //Virtual update method, functions for any scenarios that should be detected in real time
    public virtual void Update()
    {
        if(health <= 0)
        {
            Dies();
        }
    }
    
    //Level setter, should function for instantiating the levels of enemies and levelling up the player
    public void levelSetter(int level)
    {
        this.level = level;
    }

    //Health adder, should function for both healing and hurting
    public void healthAdder(int health)
    {
        if (this.health + health > maxHealth){
            this.health = maxHealth;
        } else {
            this.health += health;
        }
    }

    public void hurt(int health){
        if (this.health - health < 0){
            this.health = 0;
        } else {
            this.health -= health;
        }
    }

    public int getLevel()
    {
        return level;
    }

}
