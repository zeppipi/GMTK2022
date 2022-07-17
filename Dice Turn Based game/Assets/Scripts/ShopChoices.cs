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
        dice = GameObject.FindGameObjectWithTag("Dice").GetComponent<Dice>();
    }
    private void Start() {
        dice = GameObject.FindGameObjectWithTag("Dice").GetComponent<Dice>();
        
    }
    public void setItems(){
        for(int i = 0; i < items.Length; i++){
            int side = dice.roll();
            int randomBuff = UnityEngine.Random.Range(1, buffs.Length);
            items[i].setBuff(buffs[randomBuff], side, buttonObjects[side-1].GetComponent<PlannerItemView>());
        }
    }
}
