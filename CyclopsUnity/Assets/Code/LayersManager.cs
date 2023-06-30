using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayersManager : MonoBehaviour
{
    public List<GameObject> layers;

    public Layer blueLayer;
    public Layer redLayer;
    public Layer yellowLayer;

    public GameObject redDeathBoxes;
    public GameObject blueDeathBoxes;

    public bool switchesBetweenBlueRed;

    public bool canSwitch;

    void Start()
    {
        DeacativateAllLayers();
        blueLayer.Activate();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && canSwitch)
        {
            if (switchesBetweenBlueRed)
            {
                ToggleBlueAndRed();
            }
            else
            {
                ToggleBlueAndYellow();
            }
        }
    }

    public void ActivateLayer(int index)
    {
        foreach (GameObject layer in layers)
        {
            layer.SetActive(false);
        }

        layers[index].SetActive(true);
    }

    public void DeacativateAllLayers()
    {
        blueLayer.Deactivate();
        redLayer.Deactivate();
        yellowLayer.Deactivate();
    }

    public void ToggleBlueAndRed()
    {
        if (blueLayer.isActive)
        {
            blueLayer.Deactivate();
            redLayer.Activate();
            HUD.Instance.UseRedLens();
            CharacterAnimationManager.Instance.ShowRedLens();

            blueDeathBoxes.SetActive(false);
            redDeathBoxes.SetActive(true);
        }
        else
        {
            redLayer.Deactivate();
            blueLayer.Activate();
            HUD.Instance.UseBlueLens();
            CharacterAnimationManager.Instance.ShowBlueLens();

            blueDeathBoxes.SetActive(true);
            redDeathBoxes.SetActive(false);
        }

        SoundManager.Instance.PlaySound(SoundManager.SoundEffect.Glasses);
    }

    public void ToggleBlueAndYellow()
    {
        if (blueLayer.isActive)
        {
            blueLayer.Deactivate();
            yellowLayer.Activate();
            HUD.Instance.UseYellowLens();
            CharacterAnimationManager.Instance.ShowYellowLens();
        }
        else
        {
            yellowLayer.Deactivate();
            blueLayer.Activate();
            HUD.Instance.UseBlueLens();
            CharacterAnimationManager.Instance.ShowBlueLens();
        }

        SoundManager.Instance.PlaySound(SoundManager.SoundEffect.Glasses);
    }

    public void ActivateRedLayer()
    {
        redLayer.Activate();
        blueLayer.Deactivate();
    }

    public void ActivateBlueLayer()
    {
        redLayer.Deactivate();
        blueLayer.Activate();
    }
}
