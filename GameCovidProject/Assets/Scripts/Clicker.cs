using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{

    Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //Debug.Log("Screen touched!");
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100)) 
            {
                //Debug.Log(hit.transform.gameObject.name);
                MaskState m = hit.transform.GetComponent<MaskState>();
                if (m != null) m.PutIn();
            }

        }

    }

}
