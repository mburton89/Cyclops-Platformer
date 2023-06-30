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
        if (Input.GetKeyDown(KeyCode.F));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        layersManager.ActivateRedLayer();
    }
}
