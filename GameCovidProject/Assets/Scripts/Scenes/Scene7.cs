using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7 : MonoBehaviour
{
    public CursorControls controls;
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
        //controls = GameObject.Find("SceneController").GetComponent<Scenes>().controls;
        controls = new CursorControls();
    }

    private void Start()
    {
        controls.Mouse.Click.started += _ => PerformedClick();
    }

    private void PerformedClick()
    {
        DetectObjects();
    }

    private void DetectObjects()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        
        /*RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider != null)
            {
                Debug.Log("3D Hit: " + hit.collider.tag);
            }
        }
        
        RaycastHit[] hits = Physics.RaycastAll(ray, 200);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].collider != null)
            {
                Debug.Log("3D Hit All: " + hits[i].collider.tag);
            }
        }

        RaycastHit[] hitsNonAlloc = new RaycastHit[1];
        int numberOfHits = Physics.RaycastNonAlloc(ray, hitsNonAlloc);
        for (int i = 0; i < numberOfHits; i++)
        {
            if (hitsNonAlloc[i].collider != null)
            {
                Debug.Log("3D Hit Non Alloc All: " + hitsNonAlloc[i].collider.tag);
            }
        }*/
        
        RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if(hits2D.collider != null)
        {
            if(hits2D.collider.tag == "RightTable")
            {
                Debug.Log("Hits 2D Collider: " + hits2D.collider.tag);
                FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1);
            }
            else if(hits2D.collider.tag == "WrongTable")
            {
                FindObjectOfType<ContaminationManager>().gotContaminated(1);
                FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1);
            }
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
