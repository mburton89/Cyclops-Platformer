using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    public Transform currentCheckpoint; //create checkpoint manager
    public GameObject player;
    private Transform playerPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
           
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Something has left");

        if (other.tag == "Player")
        {
            Debug.Log("Player has left");
            playerPosition.position = currentCheckpoint.position;
        }
    }
}
