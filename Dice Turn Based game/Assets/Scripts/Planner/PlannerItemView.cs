using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Class to control the viewing of the specific items in the planner
public class PlannerItemView : MonoBehaviour
{
    //Set how this item looks like
    [SerializeField]    
    private Action action;
    private Image image;
    [SerializeField]
    private Button button;

    private int position = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    public Action GetAction(){
        return action;
    }

    public void setAction(GameObject newActionObject){  
        if (newActionObject != null) {
            action = newActionObject.GetComponent<Action>();
        } else {
            action = null;
        }
    }

    public void setPosition (int position){
        this.position = position;
    }

    public void resetPosition(){
        this.position = -1;
    }

    public int getPosition(){
        return this.position;
    }
}
