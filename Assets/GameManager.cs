using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     Player player1 = new Player();
     Player player2 = new Player();
    // Start is called before the first frame update
    void Start()
    {
   
        player1.InitializePlayer("Rana",70);
        player2.InitializePlayer("Hussam",100);
        player1.Heal(20);
        player1.Heal(false);
        Debug.Log("Health for player1 "+player1.health);
        player1.Heal(20);
        player1.Heal(true);
        Debug.Log("Health after Restore for player1 "+player1.health);
        player2.Heal(10);
        player2.Heal(true);
        Debug.Log("Health after Restore for player2 "+player2.health);
        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
