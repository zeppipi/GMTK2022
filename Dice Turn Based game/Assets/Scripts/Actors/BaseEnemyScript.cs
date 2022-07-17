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

    
    //The most significant thing in this code now is just how enemies will transfer XP when it's defeated
    public override void Dies()
    {
        playerScript.xpAdder(xpReward);
        Destroy(this.gameObject);
    }

    //At the start, make the enemies aware of what the player has
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerScript = playerObject.GetComponent<PlayerBehaviour>();
    }

    public abstract string attack(int rolls, int turns);

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
