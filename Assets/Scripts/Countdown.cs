using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timeRanOut = false;
    public GameObject player;
    public GameObject blackHole;
    public GameObject setupNewStage;
    //public GameObject slowMotion;

    void Update()
    {
        if (!timeRanOut)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                for (int i = 0; i < ObjectManager.instance.objects.Count; i++) 
                {
                    ObjectManager.instance.objects[i].GetComponent<SpriteRenderer>().enabled = false;
                }
                timeRanOut = true;
                player.SetActive(true);
                blackHole.SetActive(true);
                //slowMotion.GetComponent<SlowMotion>().MakeUsable();
            }
        }
        else
        {
        
        }
    }
}
