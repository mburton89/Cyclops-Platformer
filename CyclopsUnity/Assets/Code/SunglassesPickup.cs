using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunglassesPickup : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        SoundManager.Instance.PlaySound(SoundManager.SoundEffect.SwitchTrigger);
        HUD.Instance.UseBlueLens();
        CharacterAnimationManager.Instance.ShowBlueLens();
        FindObjectOfType<LayersManager>().canSwitch = true;
        Destroy(gameObject);
    }
}
