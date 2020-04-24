using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float MovementDelay;

    public float Amplitude = 1;
    public float VerticalShift;
    public float Speed = 1;
    public float PhaseShift;

    public MeshRenderer Renderer;

    void Update()
    {
        Vector3 position = transform.position;
        position.y = GetCubeHeight(Time.time - MovementDelay);
        transform.position = position;

        Renderer.material.color = new Color(1, 0, 0);
    }

    float GetCubeHeight(float time)
    {
        return Amplitude * Mathf.Sin(Speed * (time + PhaseShift)) + VerticalShift;
    }
}
