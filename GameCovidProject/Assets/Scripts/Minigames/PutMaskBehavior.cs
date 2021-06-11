using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutMaskBehavior : MonoBehaviour
{
    private CursorControls controls;
    private Camera mainCamera;
    public GameObject person;
    [SerializeField] private Sprite[] personSp;
    public Scene6 scene;

    private void Awake()
    {
        mainCamera = Camera.main;
        controls = new CursorControls();
    }

    void Start()
    {
        controls.Mouse.Click.performed += _ => PerformedClick();
    }

    private void PerformedClick()
    {
        DetectObjects();
    }

    private void DetectObjects()
    {
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        
        RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if (hits2D.collider != null)
        {
            if (hits2D.collider.gameObject == this.gameObject)
            {
                person.GetComponent<SpriteRenderer>().sprite = personSp[1];
                scene.isWithoutMask = false;
                scene.timePassed = 0;
                Destroy(this.gameObject);
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
