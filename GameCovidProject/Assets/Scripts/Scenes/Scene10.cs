using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene10 : MonoBehaviour
{
    bool minigameStarted = false;
    [SerializeField] GameObject minigame;

    void Start()
    {
        GetComponent<DialogueManager>().StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<DialogueManager>().DisplayNextSentence();
            if(!minigameStarted && GetComponent<DialogueManager>().sentences.Count == 0)
            {
                minigame.SetActive(true);
                minigameStarted = true;
            }
        }
    }
}
