using UnityEngine;

public class SpriteBob : MonoBehaviour
{
    public float bobSpeed = 1f; // Speed of the bobbing motion
    public float bobHeight = 0.5f; // Height of the bobbing motion
    private float startY; // Starting Y position of the sprite

    private void Start()
    {
        startY = transform.position.y; // Store the starting Y position
    }

    private void Update()
    {
        // Calculate the new Y position based on sine wave
        float newY = startY + Mathf.Sin(Time.time * bobSpeed) * bobHeight;

        // Update the sprite's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}