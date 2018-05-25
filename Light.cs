﻿using System.Collections;
using UnityEngine;

//when making a custom class, serializable allows unity to input values
[System.Serializable]
public class DataClass
{
    //this allows the user to input an integer
    public int myInt;
    //this allows the user to input a float number
    public float myFloat;
}

public class FirstScript : MonoBehaviour
{
    //Initializes light object to variable "myLight" to use in the code
    public Light myLight;

    void Awake()
    {
        //calls addTwo method
        int myVar = addTwo(9,2);
        //this sends the value of myVar to the console
        Debug.Log(myVar);
    }
    // Update is called once per frame
    void Update()
    {
        //calls myFunction method
        myFunction();
    }


    /**
     * This method controls the light.
     * If space is down, the light is turned on,
     * if space is up, the light is turn off.
     * */
    void myFunction()
    {
        //when space key is down...
        if (Input.GetKeyDown("space"))
        {
            //light is turned on
            myLight.enabled = true;
        }
        //if space key is up...
        //could have also used myLight.enabled = !myLight.enabled;
        //! is the same as not
        if (Input.GetKeyUp("space"))
        {
            //light is turned off
            myLight.enabled = false;
        }
    }

    /**
     * This method should return the addition of two values
     * 
     * @param   x   The value of the first parameter
     * @param   y   The value of the second parameter
     * @return   returnValue   The value of x + y
     * */

    int addTwo(int x, int y)
    {
        
        //makes integer storing the value from the addition of the passed values(parameters)9 and 2
        int returnValue = x + y;
        //returns the value of returnValue variable
        return returnValue;
    }
}
