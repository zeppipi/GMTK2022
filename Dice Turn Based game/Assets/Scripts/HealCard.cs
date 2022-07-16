using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCard : ActionCard
{
    void Start()
    {
        GameObject newActionObject = new GameObject();
        newActionObject.AddComponent<HealAction>();
        actionObject = newActionObject;
        setUpCard();
    }

}
