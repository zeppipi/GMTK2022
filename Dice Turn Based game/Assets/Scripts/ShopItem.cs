using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItem : MonoBehaviour
{
    [SerializeField]
    private GameObject shopPanel;
    private Button button;
    [SerializeField]
    private Image image;
    private Buff offeredBuff;

    [SerializeField]
    private TextMeshProUGUI tmp;

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
        Debug.Log(pivToSet);
        pivToSet.addBuff(offeredBuff);
        shopPanel.SetActive(false);
    }

    public void setBuff(GameObject buffPrefab, int side, PlannerItemView piv){
        if(buffPrefab != null){
            offeredBuff = buffPrefab.GetComponent<Buff>();
            this.side = side;
            pivToSet = piv;
            this.gameObject.GetComponent<Image>().overrideSprite = buffPrefab.GetComponent<SpriteRenderer>().sprite;
            tmp.SetText(buffPrefab.GetComponent<Buff>().getDesc(side));
        } else {
            buffPrefab = null;
            pivToSet = null;
        }
    }
}
