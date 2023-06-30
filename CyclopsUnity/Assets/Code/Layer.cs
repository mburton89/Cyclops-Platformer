using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using DG.Tweening;

public class Layer : MonoBehaviour
{
    public Tilemap tilemap;
    public TilemapCollider2D tilemapCollider2D;
    [HideInInspector] public bool isActive;

    public void Deactivate()
    {
        tilemap.color = new Color(tilemap.color.r, tilemap.color.g, tilemap.color.b, 0.2f);
        tilemapCollider2D.enabled = false;
        isActive = false;
    }
    public void Activate()
    {
        tilemap.color = new Color(tilemap.color.r, tilemap.color.g, tilemap.color.b, 1);
        tilemapCollider2D.enabled = true;
        isActive = true;
    }
}
