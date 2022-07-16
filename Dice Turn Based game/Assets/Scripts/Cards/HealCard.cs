using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealCard : ActionCard
{
    void Start()
    {
        action = new HealAction();
        setUpCard();
    }

}
