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

    public float Saturation = 1;
    public float Value = 1;

    [HideInInspector] public Vector2Int Index;

    void Update()
    {
        Vector3 position = transform.position;
        position.y = GetCubeHeight(Time.time - MovementDelay);
        transform.position = position;

        Renderer.material.color = Color.HSVToRGB(GetAppropriateHueForCurrentHeight(position.y), Saturation, Value);
    }

    float GetCubeHeight(float time)
    {
        return Amplitude * Mathf.Sin(Speed * (time + PhaseShift)) + VerticalShift;
    }

    float GetAppropriateHueForCurrentHeight(float height)
    {
        float max = Amplitude + VerticalShift;
        float min = -Amplitude + VerticalShift;

        return (height - min) / (max - min);
    }
}
