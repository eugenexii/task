using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float ballSpeed = 5f;
    bool moving;
    Vector2 clickedPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }

        if (moving && (Vector2)transform.position != clickedPosition)
        {
            float step = ballSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, clickedPosition, step);
        }

        else moving = false;
    }

}
