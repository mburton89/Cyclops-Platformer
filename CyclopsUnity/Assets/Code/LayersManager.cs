using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayersManager : MonoBehaviour
{
    public List<GameObject> layers;



    void Start()
    {
        ActivateLayer(0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivateLayer(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivateLayer(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivateLayer(2);
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
}
