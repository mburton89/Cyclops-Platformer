using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
}