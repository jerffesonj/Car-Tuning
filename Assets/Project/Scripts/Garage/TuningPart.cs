using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuningPart : MonoBehaviour
{
    [SerializeField] List<CarPartScriptableObject> partPrefabs;

    [SerializeField] GameObject equipButton;
    [SerializeField] GameObject buyButton;
    [SerializeField] GameObject sellButton;
    
    private List<GameObject> partsInstantiated = new List<GameObject>();

    private int currentPartIndex = 0;

    private Transform partLocation;

    enum PartLocationName
    {
        Bullbar,
        Roof,
        Weapon,
        Tires
    }

    [SerializeField] PartLocationName currentPartName;

    private void Awake()
    {
        FindPartLocation();
        InstantiateParts();
        ShowPartEquipped();
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
        foreach (CarPartScriptableObject carPart in partPrefabs)
        {
            if (carPart.part == null)
            {
                partsInstantiated.Add(null);
                continue;
            }

            GameObject clone = Instantiate(carPart.part, partLocation);
            clone.SetActive(false);
            partsInstantiated.Add(clone);
        }
    }

    void ShowPartEquipped()
    {
        foreach (CarPartScriptableObject carPart in partPrefabs)
        {
            if (carPart.equipped)
            {
                ShowPart(partPrefabs.IndexOf(carPart));
                break;
            }
        }
    }

    public void EquipCurrentItem()
    {
        if (!partPrefabs[currentPartIndex].bought)
            return;
        foreach (CarPartScriptableObject carPart in partPrefabs)
        {
            carPart.equipped = false;
        }

        partPrefabs[currentPartIndex].equipped = true;

        equipButton.SetActive(false);

    }
    public void UnequipItem()
    {
        for (int i = 0; i < partPrefabs.Count; i++)
        {
            CarPartScriptableObject carPart = partPrefabs[i];

            if (i == currentPartIndex)
                continue;

            if (carPart.equipped)
            {
                ShowPart(i);
            }
        }

        HideAllParts();

        ShowPartEquipped();
    }

    public void BuyItem()
    {
        if (partPrefabs[currentPartIndex].bought)
            return;

        if (PlayerMoney.instance.money >= partPrefabs[currentPartIndex].price)
        {
            PlayerMoney.instance.RemoveMoney(partPrefabs[currentPartIndex].price);
            partPrefabs[currentPartIndex].bought = true;

            sellButton.SetActive(true);
            buyButton.SetActive(false);
            equipButton.SetActive(false);

            EquipCurrentItem();

        }
    }

    public void SellItem()
    {
        if (!partPrefabs[currentPartIndex].bought || currentPartIndex == 0)
            return;
        PlayerMoney.instance.AddMoney(partPrefabs[currentPartIndex].price);
        partPrefabs[currentPartIndex].bought = false;
        partPrefabs[currentPartIndex].equipped = false;

        SetButtonStates(false, true, false);

    }

    void HideAllParts()
    {
        foreach (GameObject go in partsInstantiated)
        {
            if (go == null)
            {
                continue;
            }
            go.SetActive(false);
        }
    }

    public void ShowPart(int index)
    {
        HideAllParts();

        currentPartIndex = index;

        if (currentPartIndex >= partsInstantiated.Count)
            currentPartIndex = 0;
        if (currentPartIndex < 0)
            currentPartIndex = partsInstantiated.Count;

        if (partsInstantiated[currentPartIndex] != null)
            partsInstantiated[currentPartIndex].SetActive(true);

        CarPartScriptableObject selectedPart = partPrefabs[currentPartIndex];

        if (selectedPart.bought)
        {
            SetButtonStates(true, false, false);

            if (!selectedPart.equipped)
                equipButton.SetActive(true);
        }
        else
        {
            SetButtonStates(false, true, false);
        }
    }

    void SetButtonStates(bool sell, bool buy, bool equip)
    {
        sellButton.SetActive(sell);
        buyButton.SetActive(buy);
        equipButton.SetActive(equip);
    }
}
