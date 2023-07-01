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

    //public Sprite okDave;
    //public Sprite boredDave;
    //public Sprite exciteDave;
    //public Sprite pogDave;
    //public Sprite hurtDave;
    public List<Sprite> daves;
    public Image daveImage;


    private void Awake()
    {
        Instance = this;
        UseNoLens();
    }

    private void Start()
    {
        StartCoroutine(CycleThruDaves());
    }

    public void UseNoLens()
    {
        glassesImage.transform.localScale = Vector3.zero;
    }

    public void UseBlueLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        blueGlassesObject.SetActive(true);
        redGlassesObject.SetActive(false);
    }

    public void UseRedLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        blueGlassesObject.SetActive(false);
        redGlassesObject.SetActive(true);
    }

    public void UseYellowLens()
    {
        glassesImage.transform.localScale = Vector3.one;
        glassesImage.sprite = yellowGlasses;
        glassesImage.transform.DOMoveX(glassesXPosition2, secondsToAnimate, false);
    }

    private IEnumerator CycleThruDaves()
    {
        daveImage.sprite = daves[0];
        int rand = Random.Range(7, 12);
        yield return new WaitForSeconds(rand);
        int rand2 = Random.Range(0, daves.Count);
        daveImage.sprite = daves[rand2];
        yield return new WaitForSeconds(2);
        StartCoroutine(CycleThruDaves());
    }

    //public void ShowDaveBored()
    //{
    //    StartCoroutine(ShowBoredDaveCo());
    //}

    //private IEnumerator ShowBoredDaveCo()
    //{
    //    daveImage.sprite = boredDave;
    //    yield return new WaitForSeconds(2);
    //    daveImage.sprite = okDave;
    //}
}
