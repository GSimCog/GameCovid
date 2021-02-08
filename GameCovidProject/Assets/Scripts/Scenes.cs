using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenes : MonoBehaviour
{
    [SerializeField] private int actualScene = 0;

    [SerializeField] private GameObject contextPanel;

    private void Awake()
    {
        ChangeScene(actualScene);
    }

    public void ChangeScene(int changeTo)
    {
        switch (changeTo)
        {
            case 0:
                StartContextualization();
                break;
            case 1:
                Debug.Log("Cena 1");
                break;
        }
    }

    private void StartContextualization()
    {
        contextPanel.SetActive(true);
        GameObject.Find("ContextualizationText").GetComponent<TypeWriter>().fullText = AllTexts.contextualization;
    }
}
