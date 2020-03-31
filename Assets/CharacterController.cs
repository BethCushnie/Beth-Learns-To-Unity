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
            position.x += Speed * Time.deltaTime;
        // Because different computers have different frame rates, to get a consistent speed, multiple the general speed (set in unity) by Time.deltaTime
        // which is basically just 1 / fps

        transform.position = position;
    }
}
