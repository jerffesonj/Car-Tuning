using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuningPart : MonoBehaviour
{
    public List<GameObject> partPrefabs;
    public List<GameObject> partsInstantiated;

    public int currentBullbarIndex = 0;

    public Transform partLocation;

    enum PartLocationName
    {
        Bullbar,
        Roof,
        Weapon
    }

    [SerializeField] PartLocationName currentPartName;

    private void Start()
    {
        FindPartLocation();
        InstantiateParts();
    }

    void FindPartLocation()
    {
        GameObject car = GameObject.FindGameObjectWithTag("Car");

        foreach (Transform t in car.transform)
        {
            if (t.name == currentPartName.ToString())
            {
                partLocation = t;
                break;
            }
        }
    }

    void InstantiateParts()
    {
        foreach (GameObject gameObject in partPrefabs)
        {
            if(gameObject == null)
                continue;

            GameObject clone = Instantiate(gameObject, partLocation);
            clone.SetActive(false);
            partsInstantiated.Add(clone);
        }
    }

    public void ShowPart(int index)
    {
        foreach(GameObject go in partsInstantiated) 
        {
            go.SetActive(false);
        }

        currentBullbarIndex = index;

        if (currentBullbarIndex >= partsInstantiated.Count)
            currentBullbarIndex = 0;
        if (currentBullbarIndex < 0)
            currentBullbarIndex = partsInstantiated.Count;

        if(partsInstantiated[currentBullbarIndex] != null)
            partsInstantiated[currentBullbarIndex].SetActive(true);
    }
}
