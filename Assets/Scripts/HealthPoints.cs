using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPoints : MonoBehaviour
{
    public float points;

    void Update()
    {
        if (points <= 0)
        {
            if (LevelManager.instance.level > LevelManager.instance.highscore)
            {
                LevelManager.instance.highscore = LevelManager.instance.level;
            }
            SceneManager.LoadScene("LoseScreen");
        }
    }
}
