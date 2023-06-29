using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    public Transform currentCheckpoint; //create checkpoint manager
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
           
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (gameObject.tag == "Player")
        {
            player.transform.position = currentCheckpoint.transform.position;
        }
    }
}
