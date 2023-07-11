using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangieModeSwitcher : MonoBehaviour
{
    public PlayerMovementV3 running;
    public BalloonControls balloon;
    public RollyBallController roll;

    public SpriteRenderer sprite;

    public Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Reset();
            running.enabled = true;
            sprite.color = new Color(1f, 0.5f, 0.1f, 1);
            rigidbody2D.gravityScale = 3;
            rigidbody2D.drag = 0.1f;
            rigidbody2D.mass = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Reset();
            balloon.enabled = true;
            sprite.color = new Color(1,0,1,1);
            rigidbody2D.gravityScale = 0;
            rigidbody2D.drag = 3f;
            rigidbody2D.mass = 0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Reset();
            roll.enabled = true;
            sprite.color = Color.green;
            rigidbody2D.gravityScale = 6;
            rigidbody2D.drag = 0.1f;
            rigidbody2D.mass = 2;
        }
    }

    private void Reset()
    {
        running.enabled = false;
        balloon.enabled = false;
        roll.enabled = false;
    }
}
