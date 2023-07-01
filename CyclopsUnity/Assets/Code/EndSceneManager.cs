using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class EndSceneManager : MonoBehaviour
{
    public Image image;
    public Button button;

    void Start()
    {
        StartCoroutine(GoToMenu());
        button.onClick.AddListener(HandleClick);
    }

    private IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(64);
        image.DOFade(1, 1);
        yield return new WaitForSeconds(3);
        SceneTransition.Instance.TransitionToScene(0);
    }

    void HandleClick()
    {
        SceneTransition.Instance.TransitionToScene(0);
    }
}
