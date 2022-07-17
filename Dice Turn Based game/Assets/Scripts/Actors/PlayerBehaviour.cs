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

    [SerializeField]
    private float healLevelUpPercentage;

    [SerializeField]
    private float maxHealthIncreasePercentage;

    [SerializeField]
    private float maxExperienceIncreasePercentage;

    [Space]
    // Shop
    [SerializeField]
    private GameObject shopPanel;

    [Space]
    //Dice
    [SerializeField, ReadOnly]
    private int dice;
    private Dice diceScript;

    [Space]

    // Base Damage & Heal
    [SerializeField]
    private int baseDamage;

    [SerializeField]
    private float damageIncreasePercentage;

    [SerializeField]
    private int baseHeal;

    [SerializeField]
    private float healIncreasePercentage;

    //Animator
    [SerializeField]
    private Animator playerAnimator;

    //Description
    private Description playerDescription;

    //Player has leveled up
    public void levelUp()
    {
        levelSetter(this.level + 1);
        // Call the shop
        shopPanel.SetActive(true);
        shopPanel.GetComponent<ShopChoices>().setItems();

        // add health abit
        int healAmount = (int) (healLevelUpPercentage * maxHealth);
        this.healthAdder(healAmount);

        // increase max health
        maxHealth = maxHealth + (int) (maxHealth * maxHealthIncreasePercentage);

        // increase my base damage and base heal
        baseDamage = baseDamage + (int) (baseDamage * damageIncreasePercentage);

        baseHeal = baseHeal + (int) (baseDamage * healIncreasePercentage);

        neededExperience = neededExperience + (int) (neededExperience * maxExperienceIncreasePercentage);
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

    public void updateDesc()
    {
        //Change description
        playerDescription.setTempDesc("\nHealth: " + getHealth() + "\nLevel: " + getLevel());
    }

    public int getBaseHeal(){
        return baseHeal;
    }

    public int getBaseDamage(){
        return baseDamage;
    }

}
