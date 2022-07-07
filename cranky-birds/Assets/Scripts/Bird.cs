using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rigidBody2d;
    SpriteRenderer spriteRenderer;
    
    float origGravityScale;
    Color origColor;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        origGravityScale = rigidBody2d.gravityScale;
        origColor = spriteRenderer.color;
    }

    void OnMouseDown()
    {
        rigidBody2d.gravityScale = -origGravityScale;
        spriteRenderer.color = Color.green;
    }

    void OnMouseUp()
    {
        rigidBody2d.gravityScale = origGravityScale;
        spriteRenderer.color = origColor;
    }
}
