using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ActionCard : MonoBehaviour
{
    [SerializeField]
    protected PlannerController plannerController;

    protected GameObject actionObject;
    protected Image image;
    protected Button button;
    protected void setUpCard(){
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => addActionOnClick());
    }

    public void addActionOnClick(){
        plannerController.addCounter(image.color, actionObject);
    }
    

}
