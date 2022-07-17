using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyAttCard : ActionCard
{
    [SerializeField]
    private int heavyAttackDamage;
    void Start()
    {
        GameObject newActionObject = new GameObject();
        newActionObject.AddComponent<HeavyAttAction>();
        HeavyAttAction HAAction = newActionObject.GetComponent<HeavyAttAction>();
        HAAction.setDamage(heavyAttackDamage);
        actionObject = newActionObject;
        setUpCard();
    }
}
