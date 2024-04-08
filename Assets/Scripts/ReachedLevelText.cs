using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReachedLevelText : MonoBehaviour
{
    TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        text.text = "Lvl.: " + LevelManager.instance.level + " (Highscore: " + LevelManager.instance.highscore + ")";
    }
}
