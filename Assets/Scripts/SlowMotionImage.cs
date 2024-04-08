using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlowMotionImage : MonoBehaviour
{
    Image image;
    public Sprite grey;
    public Sprite color;
    public GameObject slowMotion;
    
    void Awake()
    {
        image = GetComponent<Image>();
        slowMotion.GetComponent<SlowMotion>().onUsableAgain.AddListener(ChangeImageToColor);
        slowMotion.GetComponent<SlowMotion>().onUnusableAgain.AddListener(ChangeImageToGrey);
    }

    void ChangeImageToColor()
    {
        image.sprite = color;
    }

    void ChangeImageToGrey()
    {
        image.sprite = grey;
    }
}
