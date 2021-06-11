using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour
{
    [SerializeField] private GameObject explanationPanel;
    [SerializeField] private GameObject quizPanel;

    public bool newQuiz = false;

    private CursorControls controls;

    void Start()
    {
        GetComponent<DialogueManager>().StartDialogue();

        quizPanel.SetActive(false);
        explanationPanel.SetActive(true);

        controls = GameObject.Find("SceneController").GetComponent<Scenes>().controls;
        controls.Mouse.Click.performed += _ => PerformedClick();
    }

    private void PerformedClick()
    {
        if(explanationPanel.activeSelf)
        {
            GetComponent<DialogueManager>().DisplayNextSentence();
            if (GetComponent<DialogueManager>().endDialogue)
            {
                quizPanel.SetActive(true);
                explanationPanel.SetActive(false);
                //FindObjectOfType<QuizManager>().NewQuiz();
                newQuiz = true;
            }
        }
    }

    void Update()
    {
        if (quizPanel.activeSelf)
        {
            foreach (Transform child in quizPanel.transform)
            {
                if(child.gameObject.name.Equals("AnswerBalloon") && child.gameObject.activeSelf)
                {

                }
                else if (child.gameObject.name.Equals("QuestionBalloon") && child.gameObject.activeSelf && newQuiz)
                {
                    FindObjectOfType<QuizManager>().NewQuiz();
                    newQuiz = false;
                }
            }
        }
    }
}
