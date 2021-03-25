using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTheRightImage : MonoBehaviour
{
    [SerializeField] private Image[] images;
    [SerializeField] private List<Sprite> sprites;
    private int actualLevel;

    void Start()
    {
        sprites.Add(Resources.Load<Sprite>("Minigames/ChooseRight"));

        for (int i = 0; i < images.Length; i++)
        {
            int rand = Random.Range(0, sprites.Count - 1);
            images[i].sprite = sprites[rand];
            sprites.RemoveAt(rand);
        }
    }

    public void selectImage(Image sp)
    {
        if(sp.sprite.name == "RightImage")
        {
            Debug.Log("Resposta certa.");
            FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1);
            sp.color = new Color(0, 0.5f, 0, 0.5f);
        }
        else
        {
            Debug.Log("Resposta errada.");
            FindObjectOfType<ContaminationManager>().gotContaminated(1);
            FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1);
            sp.color = new Color(0.5f, 0, 0, 0.5f);
        }
    }
}
