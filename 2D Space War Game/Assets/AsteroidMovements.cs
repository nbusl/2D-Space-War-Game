using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovements : MonoBehaviour
{
    public float speed = 1f;
    public bool MoveRight;
    //Rigidbody2D rb;

    void Update()
    {

        if (MoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0,0);
        }
    }
}
