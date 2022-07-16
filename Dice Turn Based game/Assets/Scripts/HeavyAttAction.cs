using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeavyAttAction : Action
{   
    [SerializeField]
    private PlayerBehaviour player;

    [SerializeField]
    private BaseEnemyScript enemy;

    private Button button;
    public HeavyAttAction(){
        this.ID = "HeavyAttack";
    }

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(() => execute());
    }

    public override void execute(){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();

        // Only attack the first enemy in the array
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0].GetComponent<BaseEnemyScript>();

        enemy.hurt(25);
    }
    public new string getId(){
        return ID;
    }
}
