using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    private CursorControls controls;

    void Start()
    {
        GetComponent<DialogueManager>().StartDialogue();

        controls = GameObject.Find("SceneController").GetComponent<Scenes>().controls;
        controls.Mouse.Click.started += _ => PerformedClick();
    }

    private void PerformedClick()
    {
        GetComponent<DialogueManager>().DisplayNextSentence();
        FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1);
    }
}
