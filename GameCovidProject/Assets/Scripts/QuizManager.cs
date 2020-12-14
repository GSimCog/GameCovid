using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class QuizManager : MonoBehaviour
{
    private Button[] answerButtons = new Button[3];
    private Text questionText;
    private Button rightAnswer;
    List<Question> questions = new List<Question>();

    private void Awake()
    {
        questionText = GameObject.Find("Question").GetComponent<Text>();
        for(int i = 1; i <= 3; i++)
        {
            answerButtons[i - 1] = GameObject.Find("Answer_" + i).GetComponent<Button>();
        }
    }

    void Start()
    {
        ReadCSVFile();
        LoadQuestion();
    }

    public void NewQuiz()
    {
        LoadQuestion();
    }

    public void CheckAnswer(Button btn)
    {
        if(rightAnswer == btn)
        {
            Debug.Log("Resposta certa");
        }
        else Debug.Log("Resposta errada");
    }

    void LoadQuestion()
    {
        int rand = RandomQuestion();
        questionText.text = questions[rand].question;
        for(int i = 0; i < answerButtons.Length; i++)
        {
            Text newAnswer = answerButtons[i].GetComponentInChildren<Text>() as Text;
            newAnswer.text = questions[rand].answers[i];
        }
        rightAnswer = answerButtons[questions[rand].rightAnswer - 1];
    }

    int RandomQuestion()
    {
        return Random.Range(0, questions.Count);
    }

    private void ReadCSVFile()
    {
        TextAsset questionData = Resources.Load<TextAsset>("Questions Table");
        
        string[] data = questionData.text.Split(new char[] { '\n' });

        for(int i = 1; i < data.Length; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            Question q = new Question();
            q.question = row[0];
            q.answers[0] = row[1];
            q.answers[1] = row[2];
            q.answers[2] = row[3];
            int.TryParse(row[4], out q.rightAnswer);

            questions.Add(q);
        }
    }
}

public class Question
{
    public string question;
    public string[] answers = new string[3];
    public int rightAnswer;
}
