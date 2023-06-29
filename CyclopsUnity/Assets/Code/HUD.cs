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

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UseBlueLens();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UseRedLens();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UseYellowLens();
        }
    }

    public void UseNoLens()
    {
        glassesImage.transform.localScale = Vector3.zero;
    }

    public void UseBlueLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        glassesImage.transform.DOMoveX(glassesXPosition1, secondsToAnimate, false);
    }

    public void UseRedLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        glassesImage.sprite = redGlasses;
        glassesImage.transform.DOMoveX(glassesXPosition2, secondsToAnimate, false);
    }

    public void UseYellowLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        glassesImage.sprite = yellowGlasses;
        glassesImage.transform.DOMoveX(glassesXPosition2, secondsToAnimate, false);
    }
}