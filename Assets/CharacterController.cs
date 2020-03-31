// GetKey is true if the key is down during the frame
// GetKeyDown is true only if this is the first frame where the key is down

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKeyDown(KeyCode.W))
            position.x++;

        if (Input.GetKeyDown(KeyCode.S))
            position.x--;

        if (Input.GetKeyDown(KeyCode.A))
            position.z++;

        if (Input.GetKeyDown(KeyCode.D))
            position.z--;

        transform.position = position;
    }
}
