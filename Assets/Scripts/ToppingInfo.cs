using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", 
                 menuName = "ScriptableObjects/ToppingInfo")]
public class ToppingInfo : ScriptableObject
{
    public string label;
    public float amountPerUnit;
}
