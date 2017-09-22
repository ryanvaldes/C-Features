using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Variables
{
    public class RigidMovement : MonoBehaviour
    {
        public float acceleration = 20f;
        public float deceleration = 20f;

        private Rigidbody2D rigid2D;


        // Use this for initialization
        void Start()
        {
            // get component
            rigid2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            // check if W is pressed
            if (Input.GetKey(KeyCode.W))
            { // add force up
                rigid2D.AddForce(new Vector2(0, acceleration));
            }

            // check if S is pressed
            if (Input.GetKey(KeyCode.S))
            { 
                // add force DOWN
                rigid2D.AddForce(new Vector2(0, -acceleration));
            }
            // check if D is pressed
            if (Input.GetKey(KeyCode.D))
            { // add force RIGHT
                rigid2D.AddForce(new Vector2(acceleration, 0));
            }
            // check if A is pressed
            if (Input.GetKey(KeyCode.A))
            { // add force LEFT
                rigid2D.AddForce(new Vector2(-acceleration, 0));
            }
            // deceleration
            rigid2D.velocity = -rigid2D.velocity * deceleration;
        }
    }
}