using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject CubePrefab;
    public int NumberOfCubes;


    public List<CubeMovement> AllMovingCubes = new List<CubeMovement>();

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

    void LoopOverCubes()
    {
        for (int i = 0; i < AllMovingCubes.Count; i++)
        {
            CubeMovement cubeMovement = AllMovingCubes[i];

            cubeMovement.Amplitude++;
        }
    }

    // think of <> as "of", and [] as "at"

    // A list is a collection of many different objects of the same type. In this case, it lists all the cubes that are created.
    // It also means that you can now affect that list all together. 
    // LoopOverCubes is a loop function thing. It loops over the entire list, so you can set the properties of all the cubes at once.
}
