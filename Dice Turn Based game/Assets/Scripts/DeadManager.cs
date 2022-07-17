using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadManager : MonoBehaviour
{
    //Reference of the player
    private GameObject playerObject;
    private PlayerBehaviour playerScript;

    //Reference of the Game over screen
    [SerializeField]
    private GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerScript = playerObject.GetComponent<PlayerBehaviour>();

        gameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.getHealth() <= 0)
        {
            gameOverScreen.SetActive(true);
        }
    }

    //Reset game
    public void resetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
