using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public CheckPoint checkPointToSpawnAt;
    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = checkPointToSpawnAt.transform.position;
        SoundManager.Instance.PlaySound(SoundManager.SoundEffect.Hurt);
    }
}
