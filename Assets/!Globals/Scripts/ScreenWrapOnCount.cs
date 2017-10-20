using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script depends on the SpriteRenderer component attached to the same GameObject
[RequireComponent(typeof(SpriteRenderer))]
public class ScreenWrapOnCount : MonoBehaviour
{
    public int maxCount = 3;

    private SpriteRenderer spriteRenderer;
    // Camera
    private Bounds camBounds;
    private float camWidth;
    private float camHeight;
    private int count = 0;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void UpdateCameraBounds()
    {
        // Calculate camera bounds
        Camera cam = Camera.main;
        camHeight = 2f * cam.orthographicSize;
        camWidth = camHeight * cam.aspect;
        camBounds = new Bounds(cam.transform.position, new Vector2(camWidth, camHeight));
    }

    // Use late update since we are using the camera to wrap around
    void LateUpdate()
    {
        if(count < maxCount)
        {
            Wrap();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Wrap()
    {
        UpdateCameraBounds();
        // Store position and size in shorter variable names
        Vector3 pos = transform.position;
        Vector3 size = spriteRenderer.bounds.size;
        // Calculate the sprite's half width and half height
        float halfWidth = size.x / 2;
        float halfHeight = size.y / 2;
        float halfCamWidth = camWidth / 2f;
        float halfCamHeight = camHeight / 2f;
        //Check left
        if (pos.x + halfWidth < camBounds.min.x)
        {
            pos.x = camBounds.max.x + halfWidth;
            count++;
        }
        // Check right
        if (pos.x - halfWidth > camBounds.max.x)
        {
            pos.x = camBounds.min.x - halfWidth;
            count++;
        }
        // Check top
        if (pos.y - halfHeight > camBounds.max.y)
        {
            pos.y = camBounds.min.y - halfHeight;
            count++;
        }
        //Check bottom
        if (pos.y + halfHeight < camBounds.min.y)
        {
            pos.y = camBounds.max.y + halfHeight;
            count++;
        }
        // Set new position
        transform.position = pos;
    }
}
