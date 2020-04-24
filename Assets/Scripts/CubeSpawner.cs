using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject CubePrefab;
    public int NumberOfCubes;

    void Start()
    {
        for (int i = 0; i < NumberOfCubes; i++)
        {
            GameObject cubeObject = Instantiate(CubePrefab);

            cubeObject.transform.position = new Vector3(i, 0, 0);

            CubeMovement cubeMovement = cubeObject.GetComponent<CubeMovement>();
            cubeMovement.MovementDelay = i;
        }
    }

    void Update()
    {
    }
}
