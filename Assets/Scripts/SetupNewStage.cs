using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupNewStage : MonoBehaviour
{
    public GameObject objectSpawner;
    public GameObject countdown;
    public GameObject player;
    public GameObject blackHole;
    public GameObject slowMotion;
    void Start()
    {
        LevelManager.instance.onLevelIncreased.AddListener(SetupStage);
        player.SetActive(false);
    }

    void SetupStage()
    {
        int objectsToSpawn = 2;
        int time = 10;
        if (LevelManager.instance.level <= 4) { objectsToSpawn = 2; time = 10; }
        else if (LevelManager.instance.level <= 9) { objectsToSpawn = 3; time = 10; }
        else if (LevelManager.instance.level <= 14) { objectsToSpawn = 4; time = 15; }
        else if (LevelManager.instance.level <= 19) { objectsToSpawn = 5; time = 15; }
        else if (LevelManager.instance.level <= 24) { objectsToSpawn = 6; time = 15; }
        else if (LevelManager.instance.level <= 29) { objectsToSpawn = 7; time = 20; }
        else if (LevelManager.instance.level <= 34) { objectsToSpawn = 8; time = 20; }
        else if (LevelManager.instance.level <= 39) { objectsToSpawn = 9; time = 20; }
        else { objectsToSpawn = 10; time = 25; }


        GameObject spawner = Instantiate(objectSpawner);
        spawner.GetComponent<ObjectSpawner>().numObjectsToSpawn = objectsToSpawn;
        countdown.GetComponent<Countdown>().timeRemaining = time;
        countdown.GetComponent<Countdown>().timeRanOut = false;
        player.SetActive(false);
        blackHole.SetActive(false);
        blackHole.transform.position = blackHole.GetComponent<ConstantForwardMovement>().startPosition;
        slowMotion.GetComponent<SlowMotion>().MakeUsable();
    }
}
