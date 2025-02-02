using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MonkeyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}


