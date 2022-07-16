using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttCard : ActionCard
{
    void Start()
    {
        GameObject newActionObject = new GameObject();
        newActionObject.AddComponent<LightAttAction>();
        actionObject = newActionObject;
        setUpCard();
    }
}
