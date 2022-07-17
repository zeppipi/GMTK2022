using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    [SerializeField]
    private GameObject shopPanel;
    private Button button;
    private Image image;
    private Buff offeredBuff;

    private PlannerItemView pivToSet;
    
    private int side;
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
        pivToSet.addBuff(offeredBuff);
        shopPanel.SetActive(false);
    }

    public void setBuff(GameObject buffPrefab, int side, PlannerItemView piv){
        if(buffPrefab != null){
            offeredBuff = buffPrefab.GetComponent<Buff>();
            this.side = side;
            pivToSet = piv;
        } else {
            buffPrefab = null;
            pivToSet = null;
        }
    }
}
