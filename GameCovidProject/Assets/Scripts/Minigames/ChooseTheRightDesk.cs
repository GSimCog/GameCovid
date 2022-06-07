using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseTheRightDesk : MonoBehaviour
{

    [SerializeField]
    List<GameObject> desks = new List<GameObject>();

    [SerializeField]
    Camera cam;

    private void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            //Debug.Log("Screen touched!");
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {               
                if(hit.collider.gameObject.name == "Right Desk" && desks.Contains(hit.collider.gameObject)) 
                {
                    FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1, true);
                }
                else if (hit.collider.gameObject.name != "Right Desk" && desks.Contains(hit.collider.gameObject))
                {
                    FindObjectOfType<ContaminationManager>().gotContaminated(1);
                    FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1, false);
                }
            }

        }

    }

}
