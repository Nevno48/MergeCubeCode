using System.Collections;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    //This allows the user to enter in the value of health
    public int health;
    
    //This starts when the object it is attached to starts
    void Start()
    {
        //prints players health to console
        print("player health: " + health);
        playerDamage(health);
    }
    private void Update()
    {
        if (health <= 0)
        {   health = 0;
            Destroy(gameObject,5.5f);
            //this line also sends text to the console
            Debug.Log("The player is dead!");
        }                                                      
        else if(health >= 0)
        {
            print("You have a lot of health!!");
        }
    }
    /**
     * This method damages the player by 10 health
     * 
     * */
    void playerDamage(int damage)
    {
        health -= 10;
    }
}
