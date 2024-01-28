using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CarColor : MonoBehaviour
{
    Material carMaterial;
    // Start is called before the first frame update
    void Start()
    {
        carMaterial = GameObject.FindGameObjectWithTag("CarMesh").GetComponent<MeshRenderer>().material;

        carMaterial.color = new Color(PlayerPrefs.GetFloat("Red"), PlayerPrefs.GetFloat("Green"), PlayerPrefs.GetFloat("Blue"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
