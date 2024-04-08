using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackHoleCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (LevelManager.instance.level > LevelManager.instance.highscore)
        {
            LevelManager.instance.highscore = LevelManager.instance.level;
        }
        SceneManager.LoadScene("LoseScreen");
    }
}
