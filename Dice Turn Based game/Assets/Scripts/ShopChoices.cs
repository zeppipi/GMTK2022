using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopChoices : MonoBehaviour
{
    [SerializeField]
    private ShopItem[] items;

    [SerializeField]
    private GameObject[] buffs;
    
    public void setItems(){
        for(int i = 0; i < items.Length; i++){
            items[i].setBuff(buffs[0]);
        }
    }
}
