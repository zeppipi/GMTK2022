using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    private Button button;
    private Image image;
    private Buff offeredBuff;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => purchase());
    }

    public void purchase(){
        // This is where we put our buff into PIV
        Debug.Log(offeredBuff.name);
    }

    public void setBuff(GameObject buffPrefab){
        if(buffPrefab != null){
            offeredBuff = buffPrefab.GetComponent<Buff>();
        } else {
            buffPrefab = null;
        }
    }
}
