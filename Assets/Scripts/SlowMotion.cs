using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SlowMotion : MonoBehaviour
{
    public GameObject blackHole;
    public bool usable = true;
    private float timer;
    public UnityEvent onUsableAgain;
    public UnityEvent onUnusableAgain;

    void Update()
    {
        if(blackHole.activeSelf)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else if (timer <= 0)
            {
                blackHole.GetComponent<ConstantForwardMovement>().speed = (float)0.7;
            }
            if (Input.GetKeyDown(KeyCode.S) && usable)
            {
                blackHole.GetComponent<ConstantForwardMovement>().speed = (float)0.1;
                timer = 5;
                usable = false;
                onUnusableAgain.Invoke();
            }
        }
    }

    public void MakeUsable()
    {
        usable = true;
        onUsableAgain.Invoke();
    }
}
