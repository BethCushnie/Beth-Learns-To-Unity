using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BethsGame
{
    public class CharacterController : MonoBehaviour
    {
        public float Speed;

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 movement = GetInputVector() * Speed * Time.fixedDeltaTime;
            transform.position += transform.rotation * movement;
            // I do not understand this but by using fancy 4D vectors movement is now relative to the player's rotation

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