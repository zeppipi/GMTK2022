using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePlanner : MonoBehaviour
{
    public GameObject plannerScreen;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => onTogglePlanner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTogglePlanner(){
        plannerScreen.SetActive(!plannerScreen.activeSelf);
    }
}
