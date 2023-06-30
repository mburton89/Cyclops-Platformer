using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneTransition.Instance.TransitionToScene(2);
    }
}
