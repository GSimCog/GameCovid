using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;

    void Start()
    {
        
    }

    public void PanelPopup()
    {
        pausePanel.SetActive(!pausePanel.activeSelf);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Contextualization");
    }
}
