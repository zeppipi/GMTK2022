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
    protected int level;

    //Actor's action(s)
    [SerializeField, ReadOnly]
    protected Actions[] actionsList;

    //Execute the move(s)
    public virtual void executeMoves(){ }

    //Level setter
    public void levelSetter(int level)
    {
        this.level = level;
    }

    //Health setter
    public void healthSetter(int health)
    {
        this.health = health;
    }
    
}
