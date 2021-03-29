using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3 : MonoBehaviour
{
    void Start()
    {
        GetComponent<DialogueManager>().StartDialogue();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<DialogueManager>().DisplayNextSentence();
            FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene" + 1));
        }
    }
}
