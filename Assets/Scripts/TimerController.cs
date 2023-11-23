using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameJolt.API;
using GameJolt.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    private float timer;
    private bool isFinished;

    void Update()
    {
        if (isFinished)
        {
            return;
        }

        timer += Time.deltaTime;
        timerText.text = $"Timer: {timer}";
        if (timer >= 5)
        {
            Trophies.TryUnlock(216197);
        }

        if (timer >= 10)
        {
            isFinished = true;
            GameJoltUI.Instance.ShowTrophies();
        }
    }
}