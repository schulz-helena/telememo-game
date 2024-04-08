using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownText : MonoBehaviour
{
    public Countdown countdown;
    TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (countdown.timeRanOut)
        {
            text.text = "";
        }
        else
        {
            text.text = "" + (int)countdown.timeRemaining;
        }
    }
}
