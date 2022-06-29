using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogSpawnCooldown = 1.0f;
    public float recentDogSpawn;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time - recentDogSpawn > dogSpawnCooldown))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            recentDogSpawn = Time.time;
        }
    }
}
