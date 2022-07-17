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

    public List<Buff> buffs = new List<Buff>();
    private int position = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void addBuff(Buff newBuff){
        buffs.Add(newBuff);
    }

    private bool isBuffValid(Action action, Buff buff){
        if(action == null && buff == null){
            return false;
        } else if (buff == null){}
        // check if buff is valid on this action
        if(action.getActionType().Equals(buff.getBuffType())){
            return true;
        }
        else {
            return false;
        }
    }

    public Action GetAction(){
        
        return action;
    }

    public void setAction(GameObject newActionObject){  
        if (newActionObject != null) {
            action = newActionObject.GetComponent<Action>();
            // Loop through all buffs
            for(int i = 0; i < buffs.Count; i++){
                
                // If Buff is able to buff Action
                if (isBuffValid(action, buffs[i])){
                    // Apply the buff
                    action.addExtraBuff(buffs[i].apply());

                }
            }
            
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
