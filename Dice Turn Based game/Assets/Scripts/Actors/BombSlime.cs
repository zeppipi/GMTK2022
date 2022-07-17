using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSlime : BaseEnemyScript
{
    [SerializeField]
    private int pounceDamage;
    [SerializeField]
    private int explosionDamage;

    private void Start() {
        recalcHealth();
    }
    public override string attack(int rolls, int turns){
        int ran = UnityEngine.Random.Range(1, 2);
        if (ran == 1){
            pounce();
            return "Bomb Slime use Pounce";
        } else {
            explode();
            return "Bomb Slime explodes";
        }
    }

    private void pounce(){
        playerScript.hurt(pounceDamage);
    }

    private void explode(){
        playerScript.hurt(explosionDamage);
        this.hurt(explosionDamage - (int) (explosionDamage * 0.8));
    }
}
