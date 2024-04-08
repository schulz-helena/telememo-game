using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantForwardMovement : MonoBehaviour
{
    public float speed;
    public Vector3 startPosition;

    void Awake()
    {
        startPosition = transform.position;
        gameObject.SetActive(false);
    }

    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
