using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePlanner : MonoBehaviour
{
    //Set the image of the toggle button
    [SerializeField]
    private Sprite eyeClose;
    [SerializeField]
    private Sprite eyeOpen;
    
    //Give reference of the planner screen to be hidden
    public GameObject plannerScreen;
    
    //Get reference of the button itself and their image
    private Button button;
    private Image eye;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => onTogglePlanner());
        
        eye = button.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTogglePlanner(){
        plannerScreen.SetActive(!plannerScreen.activeSelf);

        if(plannerScreen.active)
        {
            eye.sprite = eyeOpen;
        }else
        {
            eye.sprite = eyeClose;
        }
    }
}
