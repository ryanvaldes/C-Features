using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Arrays
{
    public class Powerup : MonoBehaviour
    {
        public float speedIncrease = 5f;
        public float rotationSpeed = 30f;



        void OnTriggerEnter(Collider other)
        {
            Player p = other.GetComponent<Player>();
            if(p != null)
            {
                p.movementSpeed += speedIncrease;
                Destroy(gameObject);
            }
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
