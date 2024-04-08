using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    Button button;

    void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(QuitApp);
    }

    void QuitApp()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
