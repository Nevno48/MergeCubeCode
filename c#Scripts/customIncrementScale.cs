using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/**
 * If put on a button, the size of the object selected will increase by an amount set by an input box. 
 * 
 * @author Nevno48
 * @version 6/1/19 - 6/3/19
 */
public class customIncrementScale : MonoBehaviour
{
    //object to increase scale
    public GameObject scalableObject;
    //amount to increment scale; if positive, will increment by customIncrementAmount; if negative will decrease by customIncrementAmount;
    public float customIncrementAmount;
    //default max and min values, can be adjusted with input field
    public float max = 2;
    public float min = 0;

    /**
     * This activates at the start of the program and sets the minimum to prevent the 
     * min from being a negative value.
     */
    public void Start()
    {
        if (min == 0)
        {
            min -= customIncrementAmount;
        }
    }
    /**
    * Every frame, sets the size of the variable to the increment unless max or min is
    * the size of the object.
    */
    public void increment()
    {
        //if increment isn't negative
        if(customIncrementAmount > 0)
        {
            //if the size isn't the max
            if (scalableObject.transform.localScale.x < max && scalableObject.transform.localScale.y < max && scalableObject.transform.localScale.z < max)
            {
                scalableObject.transform.localScale += new Vector3(customIncrementAmount, customIncrementAmount, customIncrementAmount);
            }
            //if the size is the max
            if (scalableObject.transform.localScale.x == max && scalableObject.transform.localScale.y == max && scalableObject.transform.localScale.z == max)
            {
                scalableObject.transform.localScale += new Vector3((customIncrementAmount * -1), (customIncrementAmount * -1), (customIncrementAmount * -1));
            }
        }
        //if increment is negative
        if (customIncrementAmount < 0)
        {
            //if the size isn't the min
            if (scalableObject.transform.localScale.x > min && scalableObject.transform.localScale.y > min && scalableObject.transform.localScale.z > min)
            {
                scalableObject.transform.localScale += new Vector3(customIncrementAmount, customIncrementAmount, customIncrementAmount);
            }
            //if the size is the min
            if (scalableObject.transform.localScale.x == min && scalableObject.transform.localScale.y == min && scalableObject.transform.localScale.z == min)
            {
                scalableObject.transform.localScale += new Vector3((customIncrementAmount * -1), (customIncrementAmount * -1), (customIncrementAmount * -1));
            }
        }

    }
}
