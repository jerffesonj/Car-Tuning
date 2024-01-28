using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject menuButtons;
    public GameObject bullbarButtons;
    public GameObject colorButtons;
    public GameObject roofButtons;
    public GameObject weaponsButtons;
    public GameObject tiresButtons;

    public void BackMenu()
    {
        menuButtons.SetActive(true);
        bullbarButtons.SetActive(false);
        roofButtons.SetActive(false);
        weaponsButtons.SetActive(false);
        tiresButtons.SetActive(false);
        colorButtons.SetActive(false);
    }

    public void BullbarButton()
    {
        menuButtons.SetActive(false);
        bullbarButtons.SetActive(true);
        roofButtons.SetActive(false);
        weaponsButtons.SetActive(false);
        tiresButtons.SetActive(false);
        colorButtons.SetActive(false);
    }
    public void RoofButton()
    {
        menuButtons.SetActive(false);
        bullbarButtons.SetActive(false);
        roofButtons.SetActive(true);
        weaponsButtons.SetActive(false);
        tiresButtons.SetActive(false);
        colorButtons.SetActive(false);
    }
    public void WeaponButton()
    {
        menuButtons.SetActive(false);
        bullbarButtons.SetActive(false);
        roofButtons.SetActive(false);
        weaponsButtons.SetActive(true);
        tiresButtons.SetActive(false);
        colorButtons.SetActive(false);
    }
    public void TiresButton()
    {
        menuButtons.SetActive(false);
        bullbarButtons.SetActive(false);
        roofButtons.SetActive(false);
        weaponsButtons.SetActive(false);
        tiresButtons.SetActive(true);
        colorButtons.SetActive(false);
    }
    public void ColorButton()
    {
        menuButtons.SetActive(false);
        bullbarButtons.SetActive(false);
        roofButtons.SetActive(false);
        weaponsButtons.SetActive(false);
        tiresButtons.SetActive(false);
        colorButtons.SetActive(true);
    }

    public void ExitGarage()
    {
        SceneManager.LoadScene(1);
    }

}
