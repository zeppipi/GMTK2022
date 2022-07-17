using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopChoices : MonoBehaviour
{

    [SerializeField]
    private Planner plannerModel;
    [SerializeField]
    private ShopItem[] items;

    [SerializeField]
    private GameObject[] buffs;
    private List<GameObject> buttonObjects;
    private Dice dice;

    private void Awake() {
        buttonObjects = plannerModel.getButtons();
    }
    private void Start() {
        dice = GameObject.FindGameObjectWithTag("Dice").GetComponent<Dice>();
        
    }
    public void setItems(){
        for(int i = 0; i < items.Length; i++){
            // int side = dice.roll();
            int side = 1;
            items[i].setBuff(buffs[0], side, buttonObjects[side-1].GetComponent<PlannerItemView>());
        }
    }
}
