using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInsideTheBoundaries2 : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -18.95f, 224.88f),
        Mathf.Clamp(transform.position.y, -18.48f, 20.02f), transform.position.z);
    }
}
