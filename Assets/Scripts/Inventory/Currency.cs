using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    private int _currentMoney;


    public int CurrentMoney { get => _currentMoney;}

    public void SetInicialMoney(int initialMoney)
    {
        _currentMoney = initialMoney;
    }


    public bool RemoveMoney(int money)
    {
        if((_currentMoney - money) < 0)
        {
            return false;
        }

        _currentMoney -= money;
        return true;
    }

    public void AddMoney(int money)
    {
        _currentMoney += money;
    }
}
