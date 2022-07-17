using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract class for the actors, which includes the players and enemies
abstract public class Actor : MonoBehaviour
{    
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

    //Actor's description
    private Description actorDescription;

    //Execute the move(s)
    public virtual void executeMoves(){ }

    //What should be done when this actor dies?
    public virtual void Dies(){ }

    void Start()
    {
        actorDescription = this.GetComponent<Description>();
        
        //Keep track of the description
        actorDescription.setTempDesc("\nHealth: " + getHealth() + "\nLevel: " + getLevel());
        actorDescription.setDesc(actorDescription.getDesc());
    }
    
    //Virtual update method, functions for any scenarios that should be detected in real time
    public virtual void Update()
    {
        Debug.Log(this.level);
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

    public int getHealth(){
        return health;
    }

    public int getMaxHealth(){
        return maxHealth;
    }

    public void setHealth(int health){
        this.health = health;
    }

    public void setMaxHealth(int maxHealth){
        this.maxHealth = maxHealth;
    }
    
}
