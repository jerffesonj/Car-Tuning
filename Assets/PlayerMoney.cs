using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public static PlayerMoney instance;
    public int money;
    public TMP_Text moneyText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        if(PlayerPrefs.GetInt("Money") == 0)
        {
            money = 4500;
        }
        else
        {
            money = PlayerPrefs.GetInt("Money");
        }

        moneyText.text = money.ToString();
    }

    public void AddMoney(int money)
    {
        this.money += money;

        moneyText.text = this.money.ToString();

        PlayerPrefs.SetInt("Money", money);
    }

    public void RemoveMoney(int money)
    {
        this.money -= money;

        if (this.money <= 0)
            this.money = 0;
        moneyText.text = this.money.ToString();

        PlayerPrefs.SetInt("Money", money);
    }
}
