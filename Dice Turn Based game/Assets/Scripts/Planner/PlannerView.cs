using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Class to control the viewing of the whole planner
public class PlannerView : MonoBehaviour
{
    public void toggleButton(Button button){
        button.interactable = !button.interactable;
    }

    public void changeImageColor(Image img, Color color){
        img.color = color;
    }
}
