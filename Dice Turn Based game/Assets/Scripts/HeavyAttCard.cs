using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyAttCard : ActionCard
{
    void Start()
    {
        action = new HeavyAttAction();
        setUpCard();
    }
}
