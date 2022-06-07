using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{

    [SerializeField]
    private float speed;

    [SerializeField]
    private float rotation;

    private float timer;

    [SerializeField]
    private float lifeTime;

    private Transform model;

    private void Awake()
    {
        model = transform.GetChild(0);
    }

    private void Update()
    {

        timer += Time.deltaTime;
        transform.Translate(0, -speed * Time.deltaTime, 0);
        model.Rotate(rotation, rotation, 0);
        if(timer >= lifeTime) 
        {
            Destroy(this.gameObject);
        }

    }

}
