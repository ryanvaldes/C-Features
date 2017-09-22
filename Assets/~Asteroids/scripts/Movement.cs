using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace asteroids
{
    public class Movement : MonoBehaviour
    {


        public float rotationSpeed = 5f;
        public float acceleration = 20f;


        private Rigidbody2D rigid2D;
        // Use this for initialization
        void Start()
        {
            // Get rigidBody 2d component
            rigid2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()

        {

            Accelerate();
            Rotate();
        }

        void Rotate()
        {
            float inputH = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.forward, rotationSpeed * -inputH);
        }

        void Accelerate()
        {
            Vector2 up = transform.up;
            float inputV = Input.GetAxis("Vertical");
            rigid2D.AddForce(up * acceleration * inputV);
        }


    }
}
    