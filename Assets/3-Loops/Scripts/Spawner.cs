using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loops
{
    public class Spawner : MonoBehaviour
    {
        public GameObject spawnPrefab;
        public int spawnAmount = 10;
        public bool spawnRadial = false;
        [Header("radial")]
        public float spawnRadius = 5f;
        [Header("grid")]
        public int width = 20;
        public int height = 20;


        void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, spawnRadius);
        }
        // Use this for initialization
        void Start()
        {
            if (spawnRadial)
            {
                // generate prefabs randomly on start
                GenerateRandomly();
            }
            else
            {
                // generate all prefabs in grid formation
                GenerateOnGrid();
            }
           
        }


        void GenerateRandomly()
        {
            // loop up to spawnamount
            for (int i = 0; i < spawnAmount ; i++)
            {
                // 1. spawn new instance of the spawn prefab
                GameObject clone = Instantiate(spawnPrefab);
                // generate random position in circle 
                Vector3 randomPos = Random.insideUnitSphere * spawnRadius;
                
                // 3. cancel the z from random pos
                randomPos.z = 0;
                // 4 set the position of the object to spawnerpos + randomPos
                clone.transform.position = transform.position + randomPos; 
            }
           
           
        }
        void GenerateOnGrid()
        {
            // Nested loop
            // loop on width
            for (int x = 0; x < width; x++)
            {
                // loop on height
                for (int y = 0; y < height; y++)
                {
                    GameObject clone = Instantiate(spawnPrefab);
                    Vector2 pos = new Vector2(x, y);
                    clone.transform.position = pos;
                }
            }
        }
    }
}
