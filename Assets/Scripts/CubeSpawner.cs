using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    List<CubeMovement> AllMovingCubes = new List<CubeMovement>();

    void Start()
    {
        for (int i = 0; i < NumberOfCubesAlongXAxis; i++)
        {
            for (int m = 0; m < NumberOfCubesAlongZAxis; m++)
            {
                GameObject cubeObject = Instantiate(CubePrefab);

                cubeObject.transform.position = new Vector3(i, 0, m);

                CubeMovement cubeMovement = cubeObject.GetComponent<CubeMovement>();
                cubeMovement.MovementDelay = i + m;

                AllMovingCubes.Add(cubeMovement);
            }
        }

        LoopOverCubes();
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
        }
    } 
}
