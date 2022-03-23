using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInsideTheBoundaries : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -20.16f, 214f),
        Mathf.Clamp(transform.position.y, -19.49f, 18.8f), transform.position.z);
    }
}
