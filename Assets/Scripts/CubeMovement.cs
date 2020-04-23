using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = GetMovementVector();
        transform.position += movement;
    }

    Vector3 GetMovementVector()
    {
        Vector3 movement = Vector3.forward;
        //shorthand for = new Vector3(0, 0, 1);
        //which is shorthand for = new Vector3; movement++
        
        return movement;
    }
}
