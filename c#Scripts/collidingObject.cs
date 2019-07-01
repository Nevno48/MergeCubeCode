using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/**
 * Description: This allows two objects to interact with eachother to do an action.
 * Each object needs to have a collider for this script to work. The object being
 * collided into needs to have a rigidbody.This script should be placed on 
 * the object being collided into another object.
 * 
 * @author Nevno48
 * @version 6/21/19
 */
public class collidingObject : MonoBehaviour
{
    //this object needs collider and rigidbody
    //the object that is being collided into
    public GameObject collideInto;
    //the name of the object this script is attached to
    public GameObject thisObject;
    //graphical drop down menu for actions when collided
    public UnityEvent onCollideEnter = new UnityEvent();
    //graphical drop down menu for actions when not collided
    public UnityEvent onCollideExit = new UnityEvent();

    /**
     * Description: This is the method that executes when an object collides
     * into another object
     * 
     * @param col   This is the variable for the collider of the object being
     * collided into
     */
    private void OnTriggerEnter(Collider col)
    {
        //if the object being collided into has the same name as the collider 
        if (col.gameObject.name.Equals(collideInto.gameObject.name))
        {
            //do everything in the OnCollideEnter drop down menu
            onCollideEnter.Invoke();
        }
    }

    /**
     * Description: This is the method that executes when an object doesn't collide
     * into another object
     * 
     * @param col   This is the variable for the collider of the object being
     * collided into
     */
    private void OnTriggerExit(Collider col)
    {
        //do everything in the OnCollideExit drop down menu
        onCollideExit.Invoke();
    }
}
