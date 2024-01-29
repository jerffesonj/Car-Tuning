using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject menuButtons;
    [SerializeField] private GameObject bullbarButtons;
    [SerializeField] private GameObject colorButtons;
    [SerializeField] private GameObject roofButtons;
    [SerializeField] private GameObject weaponsButtons;
    [SerializeField] private GameObject tiresButtons;

    private void SetActiveMenu(GameObject menu)
    {
        menuButtons.SetActive(false);
        bullbarButtons.SetActive(false);
        roofButtons.SetActive(false);
        weaponsButtons.SetActive(false);
        tiresButtons.SetActive(false);
        colorButtons.SetActive(false);

        menu.SetActive(true);
    }

    public void BackMenu()
    {
        SetActiveMenu(menuButtons);
    }
    public void BullbarButton() 
    { 
        SetActiveMenu(bullbarButtons); 
    }
    public void RoofButton()
    {
        SetActiveMenu(roofButtons);
    }
    public void WeaponButton()
    {
        SetActiveMenu(weaponsButtons);
    }
    public void TiresButton() 
    {
        SetActiveMenu(tiresButtons);
    }
    public void ColorButton() 
    {
        SetActiveMenu(colorButtons);
    }

    public void ExitGarage()
    {
        SceneManager.LoadScene(1);
    }

}
