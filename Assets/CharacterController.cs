using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BethsGame
{
    public class CharacterController : MonoBehaviour
    {
        public float MovementSpeed;
        public float RotationSpeed;

        // Update is called once per frame
        void Update()
        {
            Vector3 movement = GetInputMovementVector() * MovementSpeed * Time.deltaTime;
            transform.position += transform.rotation * movement;

            Vector3 rotation = GetInputRotationVector() * RotationSpeed * Time.deltaTime;
            transform.position += transform.rotation * rotation;


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

        Vector3 GetInputRotationVector()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Vector3 eulerAngles = transform.eulerAngles;
                eulerAngles.y++;
                transform.eulerAngles = eulerAngles;
                // Because transform.eulerAngles is a property, you can't directly change it. So, you make a variable.

                // Another way to do this is:
                // transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 1, transform.eulerAngles.z);
            }

            if (Input.GetKey(KeyCode.E))
            {
                Vector3 eulerAngles = transform.eulerAngles;
                eulerAngles.y--;
                transform.eulerAngles = eulerAngles;
            }

        }
    }
}