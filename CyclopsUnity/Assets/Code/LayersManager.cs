using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayersManager : MonoBehaviour
{
    public List<GameObject> layers;

    public Layer blueLayer;
    public Layer redLayer;
    public Layer yellowLayer;

    public bool switchesBetweenBlueRed;

    void Start()
    {
        DeacativateAllLayers();
        blueLayer.Activate();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
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
        }
        else
        {
            redLayer.Deactivate();
            blueLayer.Activate();
        }
    }

    public void ToggleBlueAndYellow()
    {
        if (blueLayer.isActive)
        {
            blueLayer.Deactivate();
            yellowLayer.Activate();
        }
        else
        {
            yellowLayer.Deactivate();
            blueLayer.Activate();
        }
    }

    public void ActivateRedLayer()
    {
        redLayer.Activate();
        blueLayer.Deactivate();
    }
}
