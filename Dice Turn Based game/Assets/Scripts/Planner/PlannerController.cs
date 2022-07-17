using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This class is the logic of the planner
public class PlannerController : MonoBehaviour
{
    //Get the instance of the planner view and planner model
    private PlannerView plannerView;
    private Planner plannerModel;

    private void Awake() {
        plannerModel = this.GetComponent<Planner>();
    }
    public PlannerController(){
        plannerView = new PlannerView();
        
    }

    public void addCounter(Image actionImage, GameObject actionObject){
        Action action = actionObject.GetComponent<Action>();
        int counter = plannerModel.counter;
        bool isNotFull = plannerModel.counter <= 5;

        bool isValidMove = plannerModel.isActionValid(action.getId()); 
        if (isNotFull && isValidMove){
            Button button = plannerModel.getButtonByCounter(counter);
            Image image = plannerModel.getImageByCounter(counter);
            PlannerItemView piv = plannerModel.getPIVbyCounter(counter);
            piv.setAction(actionObject);
            piv.setPosition(counter);
            plannerView.toggleButton(button);
            plannerView.changeImage(image, actionImage);
            plannerModel.increaseCounter();
        } else {
            Debug.Log("List is Full");
        }
    }

}
