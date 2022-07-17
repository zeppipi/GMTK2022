using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSlime : BaseEnemyScript
{
    [SerializeField]
    private float pounceDamageMultiplier;
    [SerializeField]
    private float explosionDamageMultiplier;

 
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
        playerScript.hurt((int) (baseDamage * pounceDamageMultiplier));
    }

    private void explode(){
        int damage = (int) (baseDamage * pounceDamageMultiplier);
        playerScript.hurt(damage);
        this.hurt(damage - (int) (damage * 0.8));
    }
}
