using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour
{
    [SerializeField] private GameObject explanationPanel;
    [SerializeField] private GameObject quizPanel;

    public bool newQuiz = false;

    private void Awake()
    {
        
    }

    void Start()
    {
        GetComponent<DialogueManager>().StartDialogue();

        quizPanel.SetActive(false);
        explanationPanel.SetActive(true);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && explanationPanel.activeSelf)
        {
            GetComponent<DialogueManager>().DisplayNextSentence();
            if(GetComponent<DialogueManager>().endDialogue)
            {
                quizPanel.SetActive(true);
                explanationPanel.SetActive(false);
                //FindObjectOfType<QuizManager>().NewQuiz();
                newQuiz = true;
            }
        }

        if (quizPanel.activeSelf)
        {
            foreach (Transform child in quizPanel.transform)
            {
                Debug.Log(child.gameObject.name);
                if(child.gameObject.name.Equals("AnswerBalloon") && child.gameObject.activeSelf)
                {
                    Debug.Log("answer ativado");
                }
                else if (child.gameObject.name.Equals("QuestionBalloon") && child.gameObject.activeSelf && newQuiz)
                {
                    Debug.Log("ativos");
                    FindObjectOfType<QuizManager>().NewQuiz();
                    newQuiz = false;

                }
            }
        }
    }
}
