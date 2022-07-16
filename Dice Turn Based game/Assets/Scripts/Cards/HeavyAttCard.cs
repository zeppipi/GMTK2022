using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyAttCard : ActionCard
{
    void Start()
    {
        GameObject newActionObject = new GameObject();
        newActionObject.AddComponent<HeavyAttAction>();
        actionObject = newActionObject;
        setUpCard();
    }
    
    // void Start()
    // {
    //     action = new HeavyAttAction();
    //     setUpCard();
    // }
}
