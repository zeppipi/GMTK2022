using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAttCard : ActionCard
{
    void Start()
    {
        action = new LightAttAction();
        setUpCard();
    }
}
