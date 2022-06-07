using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7 : MonoBehaviour
{
    public CursorControls controls;
    private Camera mainCamera;

    [SerializeField]
    private GameObject[] desks;

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
