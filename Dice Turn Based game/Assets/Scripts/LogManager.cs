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
    private TextMeshProUGUI[] logs;

    [SerializeField]
    private TextMeshProUGUI currentLog;

    [SerializeField]
    private TextMeshProUGUI previousLog;

    private int counter = 0;

    public void setDiceRoll(int rolls){
        diceRolls.SetText(rolls.ToString());

    
    }

    public void addLog(string newText){
        logs[counter % 8].SetText(newText); 
        counter += 1;
    }

    public void clearArray(){
        for(int i = 0; i < logs.Length; i++){
            logs[i].SetText("");
        }
        counter = 0;
    }
    // public void setCurrentLog(string newText){
    //     setPreviousLog(currentLog.text.ToString());
    //     currentLog.SetText(newText);
    // }

    // public void setPreviousLog(string text){
    //     previousLog.SetText(text);
    // }
}
