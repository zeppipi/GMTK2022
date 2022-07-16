using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Class to control the viewing of the specific items in the planner
public class PlannerItemView : MonoBehaviour
{
    //Set how this item looks like
    [SerializeField]    
    private Action actionId;
    private Image image;
    [SerializeField]
    private Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    public Action GetAction(){
        return actionId;
    }

    public void setAction(GameObject newActionObject){
        
        actionId = newActionObject.GetComponent<Action>();
        // GameObject gO = Instantiate(newAction.gameObject) as GameObject;
        // actionId = gO.GetComponent<Action>();
        // Debug.Log(actionId.GetType());
    }
}
