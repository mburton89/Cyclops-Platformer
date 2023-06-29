using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button creditsButton;
    public Button creditsCloseButton;

    public GameObject creditsMenu;

    void Start()
    {
        startButton.onClick.AddListener(HandleStartPressed);
        creditsButton.onClick.AddListener(HandleCreditsPressed);
        creditsCloseButton.onClick.AddListener(HandleCreditsClosePressed);
    }

    void HandleStartPressed()
    {
        SceneTransition.Instance.TransitionToScene(1);
        SoundManager.Instance.PlaySound(SoundManager.SoundEffect.ButtonClick);
    }

    void HandleCreditsPressed()
    {
        creditsMenu.SetActive(true);
        SoundManager.Instance.PlaySound(SoundManager.SoundEffect.ButtonClick);
    }

    void HandleCreditsClosePressed()
    {
        creditsMenu.SetActive(false);
        SoundManager.Instance.PlaySound(SoundManager.SoundEffect.ButtonClick);
    }
}
