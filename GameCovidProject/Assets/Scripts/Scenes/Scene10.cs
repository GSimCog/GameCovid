using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene10 : MonoBehaviour
{
    bool minigameStarted = false;
    [SerializeField] GameObject minigame;

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
        if (!minigameStarted && GetComponent<DialogueManager>().sentences.Count == 0)
        {
            minigame.SetActive(true);
            minigameStarted = true;
        }
    }
}
