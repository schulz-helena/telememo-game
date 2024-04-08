using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public GameObject blackHole;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject != blackHole)
        {
            int index = ObjectManager.instance.objects.IndexOf(other.gameObject);
            ObjectManager.instance.objects[index] = null;
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<SpriteRenderer>().color = (Color)(new Color32(50, 50, 50, 255));
            other.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            other.gameObject.transform.Translate(0, 0, 0.5f);
            other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Destroy(other.gameObject.GetComponent<Rigidbody2D>());
            ObjectManager.instance.foundObjects.Add(other.gameObject);
        }
    }
}
