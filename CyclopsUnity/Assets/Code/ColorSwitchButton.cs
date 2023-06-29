using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitchButton : MonoBehaviour
{
    public LayersManager layersManager;

    public int colorLayer;
    private bool isOn = false;

    private void Awake()
    {

    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        layersManager.ActivateLayer(colorLayer);   
    }
}
