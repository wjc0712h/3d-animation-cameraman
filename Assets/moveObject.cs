using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Speed of movement
    public float speed = 5f;
    public Transform carpos;

    void Update()
    {
        // Move the object forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
