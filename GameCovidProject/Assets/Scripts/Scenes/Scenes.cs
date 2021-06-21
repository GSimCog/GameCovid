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

    public CursorControls controls;

    private void Awake()
    {
        //PlayerPrefs.SetInt("ActualScene", 11);
        actualScene = PlayerPrefs.GetInt("ActualScene");
        SetScene(actualScene);

        controls = new CursorControls();
    }

    public void SetScene(int value)
    {
        switch (value)
        {
            case 1:
                gameType = "quiz";
                break;
            case 2:
                gameType = "minigame";
                break;
            case 3:
                gameType = "message";
                break;
            case 4:
                gameType = "minigame";
                break;
            case 5:
                gameType = "minigame";
                break;
            case 6:
                gameType = "minigame";
                break;
            case 7:
                gameType = "minigame";
                break;
            case 8:
                gameType = "minigame";
                break;
            case 9:
                gameType = "message";
                break;
            case 10:
                gameType = "minigame";
                break;
            case 11:
                gameType = "message";
                break;
        }

        GameObject newScene = Instantiate(scenesPrefab[value - 1] as GameObject);
    }

    public void ChangeScene()
    {
        PlayerPrefs.SetInt("ActualScene", newScene);
        if(newScene > scenesPrefab.Length)
        {
            SceneManager.LoadScene(3);
        }
        else SceneManager.LoadScene(2);
    }

    public void EndLevel(int newValue)
    {
        newScene = newValue;
        endLevelPanel.SetActive(true);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
