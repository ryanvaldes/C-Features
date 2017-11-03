using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Platformer2D
{
    [RequireComponent(typeof(Rigidbody))]
    public class Controller2D : MonoBehaviour
    {
        public float acceleration = 20f;
        public float jumpHeaight = 10f;

        private Rigidbody rigid;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
