using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the enemy class, right now it doesn't do much but just kinda die
public class BaseEnemyScript : Actor
{
    //Set how much xp this enemy spills out
    [SerializeField]
    private int xpReward;

    //Get instance of the player and their script
    private GameObject playerObject;
    private PlayerBehaviour playerScript;

    //The most significant thing in this code now is just how enemies will transfer XP when it's defeated
    public override void Dies()
    {
        playerScript.xpAdder(xpReward);
        Destroy(this.gameObject);
    }
    
    //At the start, make the enemies aware of what the player has
    void Start()
    {
        playerObject = GameObject.Find("Player");
        playerScript = playerObject.GetComponent<PlayerBehaviour>();
    }

}
