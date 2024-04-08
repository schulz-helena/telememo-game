using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthPointsText : MonoBehaviour
{
    public HealthPoints playerPoints;
    TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        text.text = "HP: " + playerPoints.points;
    }
}
