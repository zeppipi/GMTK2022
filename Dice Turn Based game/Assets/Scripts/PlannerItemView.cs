using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlannerItemView : MonoBehaviour
{
    [SerializeField]    
    private string actionId;
    private Image image;
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
