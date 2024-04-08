using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    public int numObjectsToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        List<int> positionBiasesX = new List<int>() {-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5};
        int biasX = 0;
        List<int> positionBiasesY = new List<int>() {-3, -2, -1, 0, 1, 2};
        int biasY = 0;
        int objectIndex;

        for (int i = 0; i < numObjectsToSpawn; i++) 
        {
            objectIndex = Random.Range(0, prefabs.Count);
            GameObject clone = Instantiate(prefabs[objectIndex]);

            bool positionTaken = true;
            while (positionTaken)
            {
                biasX = positionBiasesX[Random.Range(0, positionBiasesX.Count)];
                biasY = positionBiasesY[Random.Range(0, positionBiasesY.Count)];
                positionTaken = false;
                for (int j = 0; j < ObjectManager.instance.objects.Count; j++) 
                {
                    if (ObjectManager.instance.objects[j].transform.position == new Vector3(transform.position.x + biasX, transform.position.y + biasY, transform.position.z))
                    {
                        positionTaken = true;
                    }
                }
            }

            clone.transform.position = new Vector3(transform.position.x + biasX, transform.position.y + biasY, transform.position.z);
            ObjectManager.instance.objects.Add(clone);
        }
        Destroy(gameObject);
    }
}
