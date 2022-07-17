using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI diceRolls;

    [SerializeField]
    private TextMeshProUGUI currentLog;

    [SerializeField]
    private TextMeshProUGUI previousLog;

    public void setDiceRoll(int rolls){
        diceRolls.SetText(rolls.ToString());

    
    }

    public void setCurrentLog(string newText){
        setPreviousLog(currentLog.text.ToString());
        currentLog.SetText(newText);
    }

    public void setPreviousLog(string text){
        previousLog.SetText(text);
    }
}
