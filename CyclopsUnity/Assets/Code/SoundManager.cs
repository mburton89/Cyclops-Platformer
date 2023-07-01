using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] float minRandomPitch;
    [SerializeField] float maxRandomPitch;

    public AudioSource jumpSound;
    public AudioSource hurtSound;
    public AudioSource buttonClickSound;
    public AudioSource glassesSwoosh;
    public AudioSource switchTrigger;

    public AudioSource levelMusic0;
    public AudioSource levelMusic1;
    public AudioSource levelMusic2;
    public AudioSource levelMusic3;
    public AudioSource levelMusic4;

    AudioSource currentLevelMusic;

    public enum SoundEffect
    {
        Jump,
        Hurt,
        ButtonClick,
        Glasses,
        SwitchTrigger
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            //Destroy(gameObject);
        }

        currentLevelMusic = levelMusic1;
    }

    public void PlaySound(SoundEffect soundEffect)
    {
        AudioSource audioSourceToPlay;
        float randPitch = Random.Range(minRandomPitch, maxRandomPitch);

        if (soundEffect == SoundEffect.Jump)
        {
            audioSourceToPlay = jumpSound;
        }

        else if (soundEffect == SoundEffect.Hurt)
        {
            audioSourceToPlay = hurtSound;
        }

        else if (soundEffect == SoundEffect.ButtonClick)
        {
            audioSourceToPlay = buttonClickSound;
        }

        else if (soundEffect == SoundEffect.Glasses)
        {
            audioSourceToPlay = glassesSwoosh;
        }

        else if (soundEffect == SoundEffect.SwitchTrigger)
        {
            audioSourceToPlay = switchTrigger;
        }

        else
        {
            audioSourceToPlay = null;
            Debug.LogError("Audio Source Not Assigned");
        }

        audioSourceToPlay.pitch = randPitch;
        audioSourceToPlay.Play();
    }

    public void PlayMusic(int level)
    {
        currentLevelMusic.DOFade(0, 2);

        if (level == 0)
        {
            currentLevelMusic = levelMusic0;
        }
        else if (level == 1)
        {
            currentLevelMusic = levelMusic1;
        }
        else if (level == 2)
        {
            currentLevelMusic = levelMusic2;
        }
        else if (level == 3)
        {
            currentLevelMusic = levelMusic3;
        }
        else if (level == 4)
        {
            currentLevelMusic = levelMusic4;
        }

        currentLevelMusic.DOFade(0.6f, 2);
    }
}