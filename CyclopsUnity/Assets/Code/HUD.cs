using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HUD : MonoBehaviour
{
    public static HUD Instance;

    public Sprite redGlasses;
    public Sprite yellowGlasses;
    public Image glassesImage;

    public float glassesXPosition1;
    public float glassesXPosition2;
    public float secondsToAnimate;

    public GameObject blueGlassesObject;
    public GameObject redGlassesObject;
    private void Awake()
    {
        Instance = this;
        UseNoLens();
    }

    public void UseNoLens()
    {
        glassesImage.transform.localScale = Vector3.zero;
    }

    public void UseBlueLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        //glassesImage.transform.DOMoveX(glassesXPosition1, secondsToAnimate, false);
        blueGlassesObject.SetActive(true);
        redGlassesObject.SetActive(false);
    }

    public void UseRedLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        //glassesImage.sprite = redGlasses;
        //glassesImage.transform.DOMoveX(glassesXPosition2, secondsToAnimate, false);
        blueGlassesObject.SetActive(false);
        redGlassesObject.SetActive(true);
    }

    public void UseYellowLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        glassesImage.sprite = yellowGlasses;
        glassesImage.transform.DOMoveX(glassesXPosition2, secondsToAnimate, false);
    }
}
