using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameJolt.API;
using GameJolt.UI;

public class MoneyController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    private float money;
    private bool isFinished;

    void Update()
    {
        if (isFinished)
        {
            return;
        }

       
        float moneyEarnRate = 2.5f; 

        money += moneyEarnRate * Time.deltaTime;
        moneyText.text = $"Money: ${money:F2}";

        if (money >= 5)
        {
            Trophies.TryUnlock(216223);
        }

        if (money >= 9)
        {
            Trophies.TryUnlock(216224);
        }

        if (money >= 10)
        {
            isFinished = true;
        }
    }
}
