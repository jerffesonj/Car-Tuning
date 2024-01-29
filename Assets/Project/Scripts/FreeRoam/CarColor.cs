using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarColor : MonoBehaviour
{
    Material carMaterial;

    void Start()
    {
        SetCarColor();
    }

    void SetCarColor()
    {
        carMaterial = GameObject.FindGameObjectWithTag("CarMesh").GetComponent<MeshRenderer>().material;

        carMaterial.color = new Color(PlayerPrefs.GetFloat("Red"), PlayerPrefs.GetFloat("Green"), PlayerPrefs.GetFloat("Blue"));
    }
}
