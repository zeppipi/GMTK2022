using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Class that makes the planner object, includes all of the base characteristics of a planner
public class Planner : MonoBehaviour
{
    //Set how many objects the planner holds, should always be 6, but in the rare case that changes, this would be where to change it
    [SerializeField]
    private int plannerSize;
    
    //List o' buttons
    public List<GameObject> buttonObjects = new List<GameObject>(6);    //hardcoded for now
    public int counter = 0;

    //With checking the status of the planner, is an action valid?
    public bool isActionValid(string actionID){
        int amount = 0;
        for (int i = 0; i < buttonObjects.Count; i++){
            PlannerItemView piv = buttonObjects[i].GetComponent<PlannerItemView>();
            if (piv.GetAction().Equals(actionID)){
                amount += 1;
            }
        }
        if (amount >= 2){
            return false;
        } else {
            return true;
        }
    }

    //Getter for the size of the planner
    public int getPlannerSize()
    {
        return plannerSize;
    }
    
    //Getter for a specific button in the list of buttons in the planner
    public Button getButtonByCounter(int counter){
        Debug.Log(buttonObjects.Count);
        Button button = buttonObjects[counter].GetComponent<Button>();
        return button;
    }

    //Getter for the images in the buttons
    public Image getImageByCounter(int counter){
        Image image = buttonObjects[counter].GetComponent<Image>();
        return image;
    }

    //Getter for the planner item view in the buttons
    public PlannerItemView getPIVbyCounter(int counter){
        PlannerItemView piv = buttonObjects[counter].GetComponent<PlannerItemView>();
        return piv;
    }

    public void increaseCounter(){
        counter += 1;
    }
}
