using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : QuizManager
{
    [SerializeField] private int actualScene;
    public string gameType;
    public GameObject[] scenesPrefab;
    [SerializeField] private GameObject endLevelPanel;
    private int newScene;

    private void Awake()
    {
        //PlayerPrefs.SetInt("ActualScene", 4);
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
            case 5:
                Debug.Log("Cena 5");
                gameType = "minigame";
                break;
            case 6:
                Debug.Log("Cena 6");
                gameType = "minigame";
                break;
            case 7:
                Debug.Log("Cena 7");
                gameType = "minigame";
                break;
            case 8:
                Debug.Log("Cena 8");
                gameType = "minigame";
                break;
            case 9:
                Debug.Log("Cena 9");
                gameType = "message";
                break;
            case 10:
                Debug.Log("Cena 10");
                gameType = "minigame";
                break;
            case 11:
                Debug.Log("Cena 11");
                gameType = "message";
                break;
        }

        Instantiate(scenesPrefab[value - 1] as GameObject);
    }

    public void ChangeScene()
    {
        PlayerPrefs.SetInt("ActualScene", newScene);
        SceneManager.LoadScene("Teste");
    }

    public void EndLevel(int newValue)
    {
        newScene = newValue;
        endLevelPanel.SetActive(true);
    }
}
