using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenes : QuizManager
{
    [SerializeField] private int actualScene = 1;
    public string gameType;

    private void Awake()
    {
        ChangeScene(actualScene);
    }

    public void ChangeScene(int changeTo)
    {
        switch (changeTo)
        {
            case 1:
                Debug.Log("Cena 1");
                gameType = "quiz";
                break;
            case 2:
                Debug.Log("Cena 2");
                break;
        }
    }
}
