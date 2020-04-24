using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject CubePrefab;
    public int NumberOfCubes;

    [Header("Master Variables")]
    public float MasterAmplitude = 5;
    public float MasterSpeed = 5;
    public float MasterVerticalShift = 5;
    public float MasterPhaseShift = 5;

    List<CubeMovement> AllMovingCubes = new List<CubeMovement>();

    void Start()
    {
        for (int i = 0; i < NumberOfCubes; i++)
        {
            GameObject cubeObject = Instantiate(CubePrefab);

            cubeObject.transform.position = new Vector3(i, 0, 0);

            CubeMovement cubeMovement = cubeObject.GetComponent<CubeMovement>();
            cubeMovement.MovementDelay = i;

            AllMovingCubes.Add(cubeMovement);
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
