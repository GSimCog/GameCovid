using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTheRightOrder : MonoBehaviour
{
    [SerializeField] private Button buttonToNextLevel;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private List<Button> buttons;

    int actualNumber = 0;

    void Start()
    {
        buttonToNextLevel.interactable = false;

        for (int i = 0; i < buttons.Count; i++)
        {
            int j = Random.Range(0, sprites.Count);
            buttons[i].image.sprite = sprites[j];
            sprites.RemoveAt(j);
        }
    }

    public void clickedToSelect(Button b)
    {
        int n = int.Parse(b.gameObject.GetComponentInChildren<Text>().text);
        if (n == 0)
        {
            actualNumber++;
            b.gameObject.GetComponentInChildren<Text>().text = actualNumber.ToString();
        }
        else if(n == actualNumber)
        {
            b.gameObject.GetComponentInChildren<Text>().text = 0.ToString();
            actualNumber--;
        }

        if(actualNumber == buttons.Count)
        {
            buttonToNextLevel.interactable = true;
        }
        else buttonToNextLevel.interactable = false;
    }

    public void checkAnwser()
    {
        bool allRight = true;

        for (int i = 0; i < buttons.Count; i++)
        {
            if (buttons[i].image.sprite.name != buttons[i].GetComponentInChildren<Text>().text)
            {
                allRight = false;
            }
        }

        if (!allRight)
        {
            FindObjectOfType<ContaminationManager>().gotContaminated(2);
        }
        //FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1);
    }
}
