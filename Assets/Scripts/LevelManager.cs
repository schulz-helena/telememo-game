using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int level;
    public int highscore;
    // Define an event to notify when the level increases
    public UnityEvent onLevelIncreased;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            LevelManager.instance.level = 1;
            print("Duplicated ObjectManager, ignoring this one.");
        }
        highscore = 0;
    }

    public void IncreaseLevel()
    {
        level++;
        onLevelIncreased.Invoke();
    }
}
