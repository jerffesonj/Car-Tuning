using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Car Part", menuName = "Car Part", order = 0)]
public class CarPartScriptableObject : ScriptableObject
{
    public GameObject part;
    public bool equipped;
    public bool bought;
    public int price;
}
