using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : QuizManager
{
    [SerializeField] private int actualScene;
    public string gameType;
    public GameObject[] scenesPrefab;

    private void Awake()
    {
        PlayerPrefs.SetInt("ActualScene", 1);
        actualScene = PlayerPrefs.GetInt("ActualScene");
        SetScene(actualScene);
    }

    public void SetScene(int value)
    {
        switch (value)
        {
            case 1:
                Debug.Log("Cena 1");
                gameType = "quiz";
                break;
            case 2:
                Debug.Log("Cena 2");
                gameType = "minigame";
                break;
            case 3:
                Debug.Log("Cena 3");
                gameType = "message";
                break;
            case 4:
                Debug.Log("Cena 4");
                gameType = "minigame";
                break;
        }

        Instantiate(scenesPrefab[value - 1] as GameObject);
    }

    public void ChangeScene(int newValue)
    {
        PlayerPrefs.SetInt("ActualScene", newValue);
        SceneManager.LoadScene("Teste");
    }
}
