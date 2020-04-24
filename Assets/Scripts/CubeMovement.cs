using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float MovementDelay;

    public float Amplitude;
    public float VerticalShift;

    void Update()
    {
        Vector3 position = transform.position;
        position.y = GetCubeHeight(Time.time);
        transform.position = position;
    }

    float GetCubeHeight(float time)
    {
        return Amplitude * Mathf.Sin(time) + VerticalShift;
    }
}
