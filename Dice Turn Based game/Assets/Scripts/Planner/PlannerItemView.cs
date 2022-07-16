using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Class to control the viewing of the specific items in the planner
public class PlannerItemView : MonoBehaviour
{
    //Set how this item looks like
    [SerializeField]    
    private string actionId;
    [SerializeField]
    private Image image;
    [SerializeField]
    private Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(this.gameObject.name + "'s Action is: " + action);
    }

    public string GetAction(){
        return actionId;
    }

    public void setAction(string newAction){
        actionId = newAction;
    }
}
