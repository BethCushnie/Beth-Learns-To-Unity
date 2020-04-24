using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float MovementDelay;

    public float Amplitude = 1;
    public float VerticalShift;
    public float k = 1;
    public float d;

    void Update()
    {
        Vector3 position = transform.position;
        position.y = GetCubeHeight(Time.time - MovementDelay);
        transform.position = position;
    }

    float GetCubeHeight(float time)
    {
        return Amplitude * Mathf.Sin(k * time + d) + VerticalShift;
    }
}
