using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // public Rigidbody player;
    public float moveSpeed = 6;
    private void Update()
    {
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
            // transform.position.y *= -1; 
        }
         if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        inputVector = inputVector.normalized;
        Debug.Log(inputVector);
        transform.position += (Vector3)inputVector * moveSpeed * Time.deltaTime;
        Debug.Log(inputVector);
        inputVector = new Vector2(0, 0);

    }

}
