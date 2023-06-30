using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class EndSceneManager : MonoBehaviour
{
    public Image image;

    void Start()
    {
        StartCoroutine(GoToMenu());
    }

    private IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(64);
        image.DOFade(1, 1);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
