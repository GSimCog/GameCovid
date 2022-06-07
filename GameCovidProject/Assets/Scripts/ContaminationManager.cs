using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContaminationManager : MonoBehaviour
{
    [SerializeField] private float contaminationPoints;
    [SerializeField] private Image contaminationBar;
    [SerializeField] private ContaminationBarFeedback feedback;

    void Start()
    {
        //PlayerPrefs.SetFloat("ContaminationPoints", 0);
        contaminationPoints = PlayerPrefs.GetFloat("ContaminationPoints");
        contaminationBar = GameObject.Find("ContaminationBar").GetComponent<Image>();
        UpdateContaminationBar();
    }

    private void Update()
    {
        UpdateContaminationBar();
    }

    public void gotContaminated(int gravity)
    {

        feedback.GiveFeedback();

        switch (gravity)
        {
            case 0:
                contaminationPoints += 10;
                break;
            case 1:
                contaminationPoints += 15;
                break;
            case 2:
                contaminationPoints += 20;
                break;
        }
        PlayerPrefs.SetFloat("ContaminationPoints", contaminationPoints);
        UpdateContaminationBar();
        if (contaminationPoints >= 100)
        {
            SceneManager.LoadScene("Defeat");
            PlayerPrefs.SetInt("ActualScene", 0);
        }
    }

    public float getContaminationPoints()
    {
        return contaminationPoints;
    }

    private void UpdateContaminationBar()
    {
        contaminationBar.fillAmount = contaminationPoints / 100f;
    }
}
