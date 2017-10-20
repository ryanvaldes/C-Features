using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDestroy : MonoBehaviour
{
    public GameObject spawnPrefab;
    private bool isQuitting = false;
    void OnApplicationQuit()
    {
        isQuitting = true;
    }
    // Use this for initialization
    void OnDestroy()
    {
        if (!isQuitting)
        {
            Instantiate(spawnPrefab, transform.position, transform.rotation);
        }

    }

}
