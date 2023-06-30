using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public int musicChoice;
    void OnTriggerEnter2D(Collider2D collision)
    {
        SoundManager.Instance.PlayMusic(musicChoice);
    }
}
