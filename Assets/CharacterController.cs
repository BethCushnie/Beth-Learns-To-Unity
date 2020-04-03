using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BethsGame
{
    public class CharacterController : MonoBehaviour
    {
        public float Speed;

        // Update is called once per frame
        void Update()
        {
            transform.position += GetInputVector() * Speed * Time.deltaTime;

        }

        Vector3 GetInputVector()
        {
            Vector3 movement = new Vector3();

            if (Input.GetKey(KeyCode.W))
                movement.z++;

            if (Input.GetKey(KeyCode.S))
                movement.z--;

            if (Input.GetKey(KeyCode.D))
                movement.x++;

            if (Input.GetKey(KeyCode.A))
                movement.x--;

            if (Input.GetKey(KeyCode.LeftShift))
                movement.y++;

            if (Input.GetKey(KeyCode.LeftControl))
                movement.y--;

            return movement;
        }
    }
}