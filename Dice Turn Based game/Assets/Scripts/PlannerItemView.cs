using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlannerItemView : MonoBehaviour
{
    [SerializeField]    
    private Action actionId;
    private Image image;
    private Button button;

    public GameObject prefab;
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
