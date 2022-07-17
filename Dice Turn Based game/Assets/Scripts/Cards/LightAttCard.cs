using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttCard : ActionCard
{
    [SerializeField]
    private int lightAttackDamage;
    void Start()
    {
        GameObject newActionObject = new GameObject();
        newActionObject.AddComponent<LightAttAction>();
        LightAttAction LAAction = newActionObject.GetComponent<LightAttAction>();
        LAAction.setDamage(lightAttackDamage);
        actionObject = newActionObject;
        setUpCard();
    }
}
