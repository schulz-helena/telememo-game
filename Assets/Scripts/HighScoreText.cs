using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreText : MonoBehaviour
{
    TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (LevelManager.instance != null)
        {
            Debug.Log(LevelManager.instance.highscore);
            text.text = "Highscore: lvl. " + LevelManager.instance.highscore;
        }
        else
        {
            Debug.Log("No Level Manager");
            text.text = "Highscore: lvl. 0";
        }
    }
}
