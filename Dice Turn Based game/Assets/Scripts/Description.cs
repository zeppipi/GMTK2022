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

    //For any progrommatically made descriptions
    private string temp_description = "";

    //Show result description of temp and not
    private string res_description;

    //Textbox here
    private TextMeshProUGUI descBox;
    private GameObject descBoxObject;
    
    //Get the text box
    private void Start() 
    {
        descBoxObject = GameObject.FindGameObjectWithTag("Description");
        descBox = descBoxObject.GetComponent<TextMeshProUGUI>(); 
    }
    
    //Message when mouse is over the thing
    void OnMouseOver() 
    {
        this.res_description = description + temp_description;
        descBox.SetText(res_description);    
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

    public void setTempDesc(string description)
    {
        this.temp_description = description;
    }

    public string getTempDesc()
    {
        return temp_description;
    }    
}
