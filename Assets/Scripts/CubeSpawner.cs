using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum WaveDelayEquation
{
    Zero,
    X,
    Z,
    X_plus_Z,
    X_times_Z,
    X_divided_by_Z_Plus_1,
}

public class CubeSpawner : MonoBehaviour
{
    public GameObject CubePrefab;
    public int NumberOfCubesAlongXAxis = 1;
    public int NumberOfCubesAlongZAxis = 1;

    [Header("Master Variables")]
    public float MasterAmplitude = 5;
    public float MasterSpeed = 5;
    public float MasterVerticalShift = 5;
    public float MasterPhaseShift = 5;

    [Space]
    public WaveDelayEquation DelayEquation;

    List<CubeMovement> AllMovingCubes = new List<CubeMovement>();

    void Start()
    {
        for (int x = 0; x < NumberOfCubesAlongXAxis; x++)
        {
            for (int z = 0; z < NumberOfCubesAlongZAxis; z++)
            {
                GameObject cubeObject = Instantiate(CubePrefab);

                cubeObject.transform.position = new Vector3(x, 0, z);

                CubeMovement cubeMovement = cubeObject.GetComponent<CubeMovement>();
                cubeMovement.MovementDelay = GetAppropriateMovementDelay(x, z);
                cubeMovement.Index = new Vector2Int(x, z);

                AllMovingCubes.Add(cubeMovement);
            }
        }

        LoopOverCubes();
    }

    float GetAppropriateMovementDelay(int x, int z)
    {
        switch (DelayEquation)
        {
            case WaveDelayEquation.X:
                return x;

            case WaveDelayEquation.Z:
                return z;

            case WaveDelayEquation.X_plus_Z:
                return x + z;

            case WaveDelayEquation.X_times_Z:
                return x * z;

            case WaveDelayEquation.X_divided_by_Z_Plus_1:
                return x / (z + 1);

            default:
                Debug.LogWarning("Invalid wave delay equation!");
                return 0;
        }
    }

    private void OnValidate()
    {
        LoopOverCubes();
    }

    void LoopOverCubes()
    {
        for (int i = 0; i < AllMovingCubes.Count; i++)
        {
            CubeMovement cubeMovement = AllMovingCubes[i];

            cubeMovement.Amplitude = MasterAmplitude;
            cubeMovement.Speed = MasterSpeed;
            cubeMovement.VerticalShift = MasterVerticalShift;
            cubeMovement.PhaseShift = MasterPhaseShift;

            cubeMovement.MovementDelay = GetAppropriateMovementDelay(cubeMovement.Index.x, cubeMovement.Index.y);

        }
    } 
}
