using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject enemySpawnPos;

    [SerializeField]
    private GameObject playerPrefab;

    [SerializeField]
    private GameObject[] enemyPrefabs;

    [SerializeField]
    private GameObject slimePrefab;

    private int numOfEnemiesDefeated = 1;

    // Start is called before the first frame update
    void Start()
    {        
        // Spawn Enemy
        Instantiate(slimePrefab, enemySpawnPos.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isEnemyExist()){
            spawnEnemy();
        }
    }

    private int calculateHealth(int level, int health, int maxHealth){
        int tempHealth = health;
        for(int i = level; i > 0; i--){
            tempHealth += (int) (maxHealth * 0.3);
        }
        return tempHealth;
    }

    private void spawnEnemy(){
        numOfEnemiesDefeated++;
        int random = UnityEngine.Random.Range(1, enemyPrefabs.Length);
        GameObject enemyToInstatiate = enemyPrefabs[random];
        BaseEnemyScript enemyScript = enemyToInstatiate.GetComponent<BaseEnemyScript>();
        enemyScript.levelSetter(numOfEnemiesDefeated);
        int newHealth = calculateHealth(numOfEnemiesDefeated, enemyScript.getHealth(), enemyScript.getMaxHealth());
        Debug.Log(newHealth);
        enemyScript.setHealth(newHealth);
        enemyScript.setMaxHealth(newHealth);
        
        Instantiate(enemyToInstatiate, enemySpawnPos.transform);
        
    }

    private bool isEnemyExist(){
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemies.Length > 0){
            return true;
        } else {
            return false;
        }   
    }

}
