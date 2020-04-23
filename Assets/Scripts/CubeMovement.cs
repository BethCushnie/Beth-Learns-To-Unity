using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float Speed;
    public float DistanceBeforeTurning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CubeIsOutsideRange())
            Speed *= -1;

        transform.position += Vector3.up * Speed * Time.deltaTime;
    }

    bool CubeIsOutsideRange()
    {
        return transform.position.y > DistanceBeforeTurning;
    }
}
