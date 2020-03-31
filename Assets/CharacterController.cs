using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.W))
            position.z += Speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
            position.z -= Speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            position.x += Speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            position.x -= Speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift))
            position.y += Speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftControl))
            position.y -= Speed * Time.deltaTime;

        transform.position = position;
    }
}
