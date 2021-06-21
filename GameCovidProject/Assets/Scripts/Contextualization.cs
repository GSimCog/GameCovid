using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contextualization : MonoBehaviour
{
    private CursorControls controls;

    private void Awake()
    {
        controls = new CursorControls();
    }

    private void Start()
    {
        GetComponent<DialogueManager>().StartDialogue();
        controls.Mouse.Click.started += _ => PerformedClick();
    }

    private void PerformedClick()
    {
        GetComponent<DialogueManager>().DisplayNextSentence();
        if (GetComponent<DialogueManager>().endDialogue)
        {
            PlayerPrefs.SetInt("ActualScene", 1);
            PlayerPrefs.SetFloat("ContaminationPoints", 0);
            SceneManager.LoadScene(2);
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
