using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContaminationManager : MonoBehaviour
{
    private int contaminationPoints;
    private Image contaminationBar;

    void Start()
    {
        contaminationPoints = PlayerPrefs.GetInt("ContaminationPoints");
        contaminationBar = GameObject.Find("ContaminationBar").GetComponent<Image>();
        UpdateContaminationBar();
    }

    public void gotContaminated(int gravity)
    {
        switch(gravity)
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
        UpdateContaminationBar();
        if (contaminationPoints >= 100)
        {
            Debug.Log("Foi contaminado!");
        }
    }

    public float getContaminationPoints()
    {
        return contaminationPoints;
    }

    private void UpdateContaminationBar()
    {
        PlayerPrefs.SetInt("ContaminationPoints", contaminationPoints);
        contaminationBar.fillAmount = contaminationPoints / 100;
        Debug.Log("Contaminação: " + contaminationPoints);
    }
}
