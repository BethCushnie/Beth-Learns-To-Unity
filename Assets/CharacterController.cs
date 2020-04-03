using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BethsGame
{
    public class CharacterController : MonoBehaviour
    {
        public float MovementSpeed = 1;
        public float RotationSpeed = 1;

        // Update is called once per frame
        void Update()
        {
            Vector3 movement = GetInputMovementVector() * MovementSpeed * Time.deltaTime;
            transform.position += transform.rotation * movement;

            float rotation = GetInputRotation() * RotationSpeed * Time.deltaTime;
            transform.Rotate(0, rotation, 0);
            // transform.Rotate adds those amounts to the degree of rotation of the player
        }

        Vector3 GetInputMovementVector()
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

        float GetInputRotation()
        {
            float rotation = 0;

            if (Input.GetKey(KeyCode.Q))
                rotation--;

            if (Input.GetKey(KeyCode.E))
                rotation++;

            return rotation;
        }
    }
}