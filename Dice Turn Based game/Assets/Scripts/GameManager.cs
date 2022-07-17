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

    private void spawnEnemy(){
        numOfEnemiesDefeated++;
        int random = UnityEngine.Random.Range(1, enemyPrefabs.Length);
        GameObject enemyToInstatiate = enemyPrefabs[random];
        BaseEnemyScript enemyScript = enemyToInstatiate.GetComponent<BaseEnemyScript>();
        enemyScript.levelSetter(numOfEnemiesDefeated);

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
