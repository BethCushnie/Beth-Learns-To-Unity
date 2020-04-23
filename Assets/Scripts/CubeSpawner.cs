using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject CubePrefab;

    void Start()
    {
        GameObject cubeObject = Instantiate(CubePrefab);

        cubeObject.transform.position = new Vector3(0, 0, 0);

        CubeMovement cubeMovement = cubeObject.GetComponent<CubeMovement>();
        cubeMovement.Speed = 3;
        cubeMovement.MaxHeight = 10;
    }

    void Update()
    {
        
    }
}
