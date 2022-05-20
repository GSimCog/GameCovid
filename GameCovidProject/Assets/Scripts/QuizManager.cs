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

    ContaminationManager contaminationManager;

    private void Awake()
    {
        contaminationManager = FindObjectOfType<ContaminationManager>();
    }

    void Start()
    {
        ReadCSVFile();
        //LoadQuestion();
    }

    public void NewQuiz()
    {
        LoadQuestion();
    }

    public void CheckAnswer(Button btn)
    {
        bool won;
        if(rightAnswer == btn)
        {
            //Debug.Log("Resposta certa");
            btn.image.color = new Color(0, 0.5f, 0, 0.5f);
            won = true;
        }
        else
        {
            //Debug.Log("Resposta errada");
            won = false;
            contaminationManager.gotContaminated(1);
            btn.image.color = new Color(0.5f, 0, 0, 0.5f);
        }
        FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1, won);
    }

    void LoadQuestion()
    {
        GetGameObjects();

        int randQ = RandomQuestion();
        questionText.text = questions[randQ].question;
        List<int> lasRandA = new List<int>();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            int randA = Random.Range(0, questions[randQ].answers.Count);
            if(lasRandA != null)
            {
                for (int j = 0; j < lasRandA.Count; j++)
                {
                    while (randA == lasRandA[j])
                    {
                        randA = Random.Range(0, questions[randQ].answers.Count);
                        j = 0;
                    }
                }
            }
            
            lasRandA.Add(randA);

            Text newAnswer = answerButtons[i].GetComponentInChildren<Text>() as Text;
            newAnswer.text = questions[randQ].answers[randA];

            if(answerButtons[i].GetComponentInChildren<Text>().text == questions[randQ].rightAnswer)
            {
                rightAnswer = answerButtons[i];
            }
        }
    }

    int RandomQuestion()
    {
        return Random.Range(0, questions.Count);
    }

    private void ReadCSVFile()
    {
        TextAsset questionData = Resources.Load<TextAsset>("Cenas_Teste");
        
        string[] data = questionData.text.Split(new char[] { '\n' });

        for(int i = 1; i < data.Length; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });
            if(int.Parse(row[0]) == PlayerPrefs.GetInt("ActualScene"))
            {
                Question q = new Question();
                int.TryParse(row[0], out q.scene);
                q.question = row[1];
                q.answers.Add(row[2]);
                q.answers.Add(row[3]);
                q.answers.Add(row[4]);

                q.rightAnswer = q.answers[0];

                questions.Add(q);
            }
        }
    }

    private void GetGameObjects()
    {
        questionText = GameObject.Find("Question").GetComponent<Text>();
        for (int i = 1; i <= 3; i++)
        {
            answerButtons[i - 1] = GameObject.Find("Answer_" + i).GetComponent<Button>();
        }
    }
}

public class Question
{
    public int scene;
    public string question;
    public List<string> answers = new List<string>();
    public string rightAnswer;
}
