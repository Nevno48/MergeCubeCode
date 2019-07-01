using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;
/**
 * Description: This adds up the total amount of correct objects and assigns
 * score to a value.
 * 
 * @author Nevno48
 * @version 6/21/19
 */
public class testScore : MonoBehaviour
{
    //array of objects to click on for increasing score
    public GameObject[] correctObjects;

    //object to set the score to
    public GameObject scoreKeeper;

    //total score after click on correct object
    public int totalScore;
    
    //this makes sure the code activates only once
    private bool checkOnce = true;
    
    /**
     * Description:This checks the correct objects to determing the score value
     */
    public void checkCorrect()
    {
        //makes sure it checks once when called
        if(checkOnce == true)
        {
            //makes sure score isn't larger than the amount of correct objects
            if (totalScore < correctObjects.Length)
            {
                for (int index = 0; index < correctObjects.Length; index++)
                {
                    if (correctObjects[index].gameObject.activeSelf == true)
                    {
                        totalScore++;
                    }
                }
                //assigns text of scoreKeeper to score value
                scoreKeeper.GetComponent<TextMeshProUGUI>().text = "Your score is: " + totalScore;
            }
            checkOnce = false;
        }
        
    }
    /**
     * Description: this resets the score value
     * 
     * @param totalScore   The new value the score is set to
     */
    public void resetScore(int totalScore)
    {
        this.totalScore = totalScore;
        checkOnce = true;
    }

}
