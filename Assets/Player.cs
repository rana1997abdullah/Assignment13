using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
   public string playerName;
   public int health;
   public int maxHealth;
   public static int playerCount = 0;

   public void InitializePlayer(string name, int initialHealth)
   {
      playerName = name;
      health = initialHealth;
      maxHealth = initialHealth;
      playerCount++;
   }
   public void Heal(int amount)
   {
      health += amount;
      Debug.Log("Player Health "+health);
   }
   public void Heal(bool fullRestore)
   {
      if (fullRestore)
      {
         health = maxHealth; //here restore health to the initialHealth and i define maxHealth for initialHealth
      }
   }
   public static void ShowPlayerCount()
   {
      Debug.Log("The Number of Players "+playerCount);
   }
}
