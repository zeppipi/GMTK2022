using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planner : MonoBehaviour
{
    public List<GameObject> buttonObjects = new List<GameObject>(6);
    public int counter = 0;

    public bool isActionValid(string actionID){
        int amount = 0;
        for (int i = 0; i < buttonObjects.Count; i++){
            PlannerItemView piv = buttonObjects[i].GetComponent<PlannerItemView>();
            if (piv.GetAction() != null && piv.GetAction().getId().Equals(actionID)){
                amount += 1;
            }
        }
        Debug.Log(amount);
        if (amount >= 2){
            return false;
        } else {
            return true;
        }
    }

    public Button getButtonByCounter(int counter){
        Debug.Log(buttonObjects.Count);
        Button button = buttonObjects[counter].GetComponent<Button>();
        return button;
    }

    public Image getImageByCounter(int counter){
        Image image = buttonObjects[counter].GetComponent<Image>();
        return image;
    }

    public PlannerItemView getPIVbyCounter(int counter){
        PlannerItemView piv = buttonObjects[counter].GetComponent<PlannerItemView>();
        return piv;
    }

    public void increaseCounter(){
        counter += 1;
    }
}
