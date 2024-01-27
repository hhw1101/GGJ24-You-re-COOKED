using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // public Rigidbody player;
    public float moveSpeed = 6;
    private SpriteRenderer sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        if (sprite == null)
        {
            Debug.LogError("Player Sprite is missing a renderer");
        }
    }
    private void Update()
    {
        public float leftLimit = -6.25;
        public float rightLimit = 6.23;
        public float topLimit = 3.86;
        public float bottomLimit = -2.91; // Z needs to be lower than cabinets
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
            sprite.flipX = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
            sprite.flipX = false;
        }
        inputVector = inputVector.normalized;
        transform.position += (Vector3)inputVector * moveSpeed * Time.deltaTime;

    }

}
