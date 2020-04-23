using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float Speed;
    public float MaxHeight;

    private float MovementSpeed;
    private void Start()
    {
        MovementSpeed = Speed;
    }

    void Update()
    {
        if (transform.position.y > MaxHeight)
            MovementSpeed = -Speed;
        
        if (transform.position.y < 0)
            MovementSpeed = +Speed;

        transform.position += Vector3.up * MovementSpeed * Time.deltaTime;
    }
}
