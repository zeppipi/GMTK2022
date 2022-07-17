using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCard : ActionCard
{
    [SerializeField]
    private int healAmount;
    void Start()
    {
        GameObject newActionObject = new GameObject();
        newActionObject.AddComponent<HealAction>();
        HealAction healAction = newActionObject.GetComponent<HealAction>();
        healAction.setHeal(healAmount);
        actionObject = newActionObject;
        setUpCard();
    }

}
