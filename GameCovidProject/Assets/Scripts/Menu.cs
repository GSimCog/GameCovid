using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Sprite[] recSprites;
    public Button continueButton;

    private void Start()
    {
        if(PlayerPrefs.GetInt("ActualScene") <= 0)
        {
            continueButton.interactable = false;
        }
        else
        {
            continueButton.interactable = true;
        }
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Contextualization");
    }

    public void OpenAndClosePanel(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
