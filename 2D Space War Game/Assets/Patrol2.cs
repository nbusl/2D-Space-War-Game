using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol2 : MonoBehaviour
{
    public float speed = 2f;
    public bool MoveLeft;
    //Rigidbody2D rb;

    void Update()
    {

        if (MoveLeft)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
        }
        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Bound"))
        {
            if (MoveLeft)
            {
                MoveLeft = false;
                //rb.velocity = Vector3.zero;
            }
            else
            {
                MoveLeft = true;
            }
        }
    }
}
