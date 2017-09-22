using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// clean up code: CTRL+K+D
// fold code: CTRL+M+O (quickly)
// unfold code: CTRL+M+P (quickly)

namespace Variables {
    public class movement : MonoBehaviour
    {

        public float movementSpeed = 20f;
        public float rotationSpeed = 20f;

    

    // Update is called once per frame
    void Update()
        {
            // if user presses w
            if (Input.GetKey(KeyCode.W))
            {  // Move up
                transform.Translate(new Vector3(0, movementSpeed, 0) * Time.deltaTime);
            }
            // IF user presses S
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, -movementSpeed, 0) * Time.deltaTime);
                // move down
            }



            if (Input.GetKey(KeyCode.A))
            {//move right
                transform.Translate(new Vector3(-movementSpeed, 0, 0) * Time.deltaTime);

            }

            // if user presses D
            if (Input.GetKey(KeyCode.D))
            {//move right
                transform.Translate(new Vector3(movementSpeed, 0, 0) * Time.deltaTime);
            }

        }
    }
}