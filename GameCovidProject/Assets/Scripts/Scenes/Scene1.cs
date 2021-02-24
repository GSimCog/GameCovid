using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : Scenes
{
    [SerializeField] private GameObject explanationPanel;
    [SerializeField] private TypeWriter dialogeText;
    [SerializeField] private GameObject quizPanel;

    DialogueTrigger dialogueTrigger;
    public bool newQuiz = false;

    private void Awake()
    {
        
    }

    void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
        dialogueTrigger.TriggerDialogue();

        quizPanel.SetActive(false);
        explanationPanel.SetActive(true);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && explanationPanel.activeSelf)
        {
            FindObjectOfType<DialogueManager>().DisplayNextSentence();
            if(FindObjectOfType<DialogueManager>().endDialogue)
            {
                quizPanel.SetActive(true);
                explanationPanel.SetActive(false);
                //FindObjectOfType<QuizManager>().NewQuiz();
                newQuiz = true;
            }
        }

        if(quizPanel.activeSelf && newQuiz)
        {
            FindObjectOfType<QuizManager>().NewQuiz();
            newQuiz = false;
        }
    }
}
