using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectManager : MonoBehaviour
{
    public static ObjectManager instance;
    public List<GameObject> objects;
    public List<GameObject> foundObjects;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            print("Duplicated ObjectManager, ignoring this one.");
        }
    }

    void Update()
    {
        bool listEmpty = true;
        for (int i = 0; i < objects.Count; i++) 
        {
            if (objects[i] != null)
            {
                listEmpty = false;
            }
        }
        if (listEmpty)
        {
            objects.Clear();
            for (int i = 0; i < foundObjects.Count; i++)
            {
                Destroy(foundObjects[i]);
            }
            foundObjects.Clear();
            LevelManager.instance.IncreaseLevel();
        }
    }

}
