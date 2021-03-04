using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contextualization : MonoBehaviour
{
    private void Start()
    {
        GetComponent<DialogueManager>().StartDialogue();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<DialogueManager>().DisplayNextSentence();
            if(GetComponent<DialogueManager>().endDialogue)
            {
                PlayerPrefs.SetInt("ActualScene", 1);
                SceneManager.LoadScene("Teste");
            }
        }
    }
}
