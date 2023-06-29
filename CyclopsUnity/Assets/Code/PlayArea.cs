using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    public Transform currentCheckpoint; //create checkpoint manager
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
           
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (gameObject.tag == "Player")
        {
            gameObject.transform.position = currentCheckpoint.transform.position;
        }
    }
}
