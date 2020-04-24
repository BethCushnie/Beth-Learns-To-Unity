using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float Speed;
    public float MaxHeight;
    public float MovementDelay;

    private float MovementSpeed;
    private void Start()
    {
        MovementSpeed = Speed;
    }

    void Update()
    {
        Vector3 position = transform.position;
        position.y = GetCubeHeight(Time.time);
        transform.position = position;
    }

    float GetCubeHeight(float time)
    {
        return Mathf.Sin(time);
    }
}
