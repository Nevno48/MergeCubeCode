using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UtilitesProperties
{
    public string myString;
    public Color MyColor;
    public GameObject myGameObject;
}

public class Utilites : MonoBehaviour
{
    public UtilitesProperties[] properties;

    Rigidbody firstRigidbody;
    Rigidbody secondRigidbody;

    
}