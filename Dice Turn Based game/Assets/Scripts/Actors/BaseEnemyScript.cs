using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the enemy class, right now it doesn't do much but just kinda die
public abstract class BaseEnemyScript : Actor
{
    //Set how much xp this enemy spills out
    [SerializeField]
    private int xpReward;

    //Get instance of the player and their script
    private GameObject playerObject;
    protected PlayerBehaviour playerScript;

    [SerializeField]
    private float maxHealthIncreasePercentage;

    //Enemy Description
    private Description enemyDescription;
    
    //The most significant thing in this code now is just how enemies will transfer XP when it's defeated
    public override void Dies()
    {
        playerScript.xpAdder(xpReward);
        Destroy(this.gameObject);
    }

    private int calculateHealth(int level){
        int tempHealth = this.health;
        for(int i = level; i > 0; i--){
            tempHealth += (int) (this.maxHealth * 0.3);
        }
        return tempHealth;
    }


    //At the start, make the enemies aware of what the player has
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerScript = playerObject.GetComponent<PlayerBehaviour>();
        int newHealth = calculateHealth(this.level);
        setHealth(newHealth);
        setMaxHealth(newHealth);
        enemyDescription = this.GetComponent<Description>();
        
        //Keep track of the description
        enemyDescription.setTempDesc("\nHealth: " + getHealth() + "\nLevel: " + getLevel());
        enemyDescription.setDesc(enemyDescription.getDesc());
    }

    public void updateDesc()
    {
        //Change description
        enemyDescription.setTempDesc("\nHealth: " + getHealth() + "\nLevel: " + getLevel());
    }


    public abstract string attack(int rolls, int turns);

    
    
}
