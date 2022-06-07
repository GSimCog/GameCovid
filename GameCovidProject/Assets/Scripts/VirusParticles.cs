using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusParticles : MonoBehaviour
{

    [SerializeField]
    private float spawnInterval;

    [SerializeField]
    private GameObject virus;

    private float timer;

    private void Update()
    {

        timer += Time.deltaTime;

        if(timer >= spawnInterval) 
        {
            timer = 0;
            float rng = Random.Range(-9, 9);
            Instantiate(virus, new Vector3(rng, 6, 0), Quaternion.identity);
        }

    }

}
