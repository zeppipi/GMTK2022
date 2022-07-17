using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightSystem : MonoBehaviour
{
    //A number to set a delay in which the logs show up in terms of seconds
    [SerializeField]
    private float textDelay;
    private string stringLog;   //bothcing it but should work
    
    [SerializeField]
    private Planner plannerModel;

    private int turns = 0;

    [SerializeField]
    private TogglePlanner toggler;

    [SerializeField]
    private LogManager logManager;

    private Button button;

    private Dice dice;

    private GameObject[] enemies;

    private List<GameObject> buttonObjects;
    // Start is called before the first frame update
    void Start()
    {
        dice = GameObject.FindGameObjectWithTag("Dice").GetComponent<Dice>();
        buttonObjects = plannerModel.getButtons();
        button = GetComponent<Button>();
        toggler = toggler.GetComponent<TogglePlanner>();
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

    private void setLog()
    {
        Debug.Log("reached!");
        logManager.setCurrentLog(this.stringLog);
    }

    public void fightClickButton(){
        
        // Roll Dice
        int rolls = dice.roll();
        turns += 1;
        logManager.setDiceRoll(rolls);
        
        // Execute from 1 to dice rolled
        PlayerBehaviour player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
        for(int index = 0; index < rolls; index++)
        {
            Action action = buttonObjects[index].GetComponent<PlannerItemView>().GetAction();
            string playerLog = "You " + action.execute(action.getDelay(), index, rolls);   //This is assuming the actions class has an execute function
            this.stringLog = playerLog;

            Debug.Log(textDelay - Time.deltaTime);
            
            //Delay
            Invoke("setLog", textDelay);
            
            //logManager.setCurrentLog(playerLog);
        }

        // Play the player animation
        player.playAnimation();
        
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < enemies.Length; i++){
            BaseEnemyScript enemyScript = enemies[i].GetComponent<BaseEnemyScript>();
            string enemyLog = enemyScript.attack(rolls, turns);
            this.stringLog = enemyLog;

            //Delay
            Invoke("setLog", textDelay);
            
            //logManager.setCurrentLog(enemyLog);
        }
        // Clear the button object
        plannerModel.clearButtons();
    }
}
