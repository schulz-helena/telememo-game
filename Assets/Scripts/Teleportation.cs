using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Teleportation : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int posX = (int)Math.Round(mousePosition.x, 0);
            double posYRoundUp = (double)Math.Ceiling(mousePosition.y) - 0.5;

            transform.position = new Vector3(posX, (float)posYRoundUp, transform.position.z);
            bool teleportedToObject = false;
            for (int i = 0; i < ObjectManager.instance.objects.Count; i++) 
            {
                if (ObjectManager.instance.objects[i] != null)
                {
                    if (transform.position == ObjectManager.instance.objects[i].transform.position)
                    {
                        teleportedToObject = true;
                    }
                    else {}
                }
            }
            if (!teleportedToObject)
            {
                HealthPoints healthPoints = GetComponent<HealthPoints>();
                healthPoints.points -= 1;
            }
        }
    }
}
