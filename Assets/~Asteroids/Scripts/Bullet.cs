using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public string triggerTag = "Asteroid";
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == triggerTag)
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
