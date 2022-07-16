using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlannerController : MonoBehaviour
{
    private PlannerView plannerView;
    private Planner plannerModel;

    private void Awake() {
        plannerModel = this.GetComponent<Planner>();
    }
    public PlannerController(){
        plannerView = new PlannerView();
        
    }

    public void addCounter(Color color, Action action){
        int counter = plannerModel.counter;
        bool isNotFull = plannerModel.counter <= 5;
        bool isValidMove = plannerModel.isActionValid(action.getId());
        if (isNotFull && isValidMove){
            Debug.Log(counter);
            Button button = plannerModel.getButtonByCounter(counter);
            Debug.Log(button);
            Image image = plannerModel.getImageByCounter(counter);
            PlannerItemView piv = plannerModel.getPIVbyCounter(counter);
            piv.setAction(action.getId());
            plannerView.toggleButton(button);
            plannerView.changeImageColor(image, color);
            plannerModel.increaseCounter();
        } else {
            Debug.Log("List is Full");
        }
    }

}
