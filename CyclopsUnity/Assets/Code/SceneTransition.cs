using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class SceneTransition : MonoBehaviour
{
    public static SceneTransition Instance;

    public Image image;
    public float secondsToFade;

    void Start()
    {
        Instance = this;
        image.DOFade(1, 0);
        ShowTransparent();
    }

    public void ShowBlack()
    {
        image.DOFade(1, secondsToFade);
    }

    public void ShowTransparent()
    {
        image.DOFade(0, secondsToFade);
    }

    public void TransitionToScene(int sceneIndex)
    {
        StartCoroutine(TransitionToSceneCo(sceneIndex));
    }

    private IEnumerator TransitionToSceneCo(int sceneIndex)
    {
        ShowBlack();
        yield return new WaitForSeconds(secondsToFade);
        SceneManager.LoadScene(sceneIndex);
    }
}
