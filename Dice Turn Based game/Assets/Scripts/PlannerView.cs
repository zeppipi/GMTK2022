using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlannerView : MonoBehaviour
{
    public void toggleButton(Button button){
        button.interactable = !button.interactable;
    }

    public void changeImageColor(Image img, Color color){
        img.color = color;
    }
}
