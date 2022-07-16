using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightSystem : MonoBehaviour
{
    [SerializeField]
    private Planner plannerModel;

    private Button button;

    private Dice dice;

    private List<GameObject> buttonObjects;
    // Start is called before the first frame update
    void Start()
    {
        dice = GameObject.FindGameObjectWithTag("Dice").GetComponent<Dice>();
        buttonObjects = plannerModel.getButtons();
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enablingCondition() == true){
            enableFightButton();
        } else {
            disableFightButton();
        }
    }

    private bool enablingCondition(){
        int amount = 0;
        for(int i = 0; i < buttonObjects.Count; i++){
            if(buttonObjects[i].GetComponent<PlannerItemView>().GetAction() != null){
                amount += 1;
            }
        }
        if(amount >= 6){
            return true;
        } else {
            return false;
        }
    }
    private void disableFightButton(){
        button.interactable = false;
    }
    private void enableFightButton(){
        button.interactable = true;
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => fightClickButton());
        
    }

    

    public void fightClickButton(){
        // Roll Dice
        int rolls = dice.roll();
        Debug.Log("You Rolled" + rolls);
        // Execute from 1 to dice rolled
        for(int index = 0; index < rolls; index++)
        {
            Action action = buttonObjects[index].GetComponent<PlannerItemView>().GetAction();
            action.execute(action.getDelay(), index, rolls);   //This is assuming the actions class has an execute function

        }
        // Clear the button object
        plannerModel.clearButtons();
    }
}
