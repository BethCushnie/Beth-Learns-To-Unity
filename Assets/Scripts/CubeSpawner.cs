using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject CubePrefab;
    public int NumberOfCubes;


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
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            LoopOverCubes();
    }

    public float MasterAmplitude = 5;

    private void OnValidate()
    {
        LoopOverCubes();
    }
    // runs whenever you touch the inspector for the object

    void LoopOverCubes()
    {
        for (int i = 0; i < AllMovingCubes.Count; i++)
        {
            CubeMovement cubeMovement = AllMovingCubes[i];

            cubeMovement.Amplitude = MasterAmplitude;
        }
    } 
}
