using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Description : MonoBehaviour
{
    // Write the description here
    [SerializeField]
    private string description;

    //Textbox here
    [SerializeField]
    private TextMeshProUGUI descBox;
    
    //Message when mouse is over the thing
    void OnMouseOver() 
    {
        descBox.SetText(description);    
    }

    //Get rid of text when mouse isnt over the thing
    void OnMouseExit() 
    {
        descBox.SetText("");    
    }

    //Set and get the text, for any scripts that needs to change the text on the spot
    public void setDesc(string description)
    {
        this.description = description;
    }

    public string getDesc()
    {
        return description;
    }
}
