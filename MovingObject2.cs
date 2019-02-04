using UnityEngine;
using System.Collections;

public class MovingObject2 : MonoBehaviour
{
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(-Time.deltaTime, 0, 0);



    }
}