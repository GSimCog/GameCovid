using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightOrderMinigame : MonoBehaviour
{

    [SerializeField]
    private Sprite[] rightOrder = new Sprite[3];

    [SerializeField]
    private Button[] spriteRenderers = new Button[3];

    private Sprite[] sprites = new Sprite[3];

    [SerializeField]
    private List<Sprite> playerAnswer = new List<Sprite>();

    private int currentButton;

    [SerializeField]
    private GameObject[] Counters = new GameObject[3];

    private void Start()
    {

        sprites = (Sprite[])rightOrder.Clone();

        List<Sprite> randomizedSprites = new List<Sprite>();
        while(randomizedSprites.Count < sprites.Length) 
        {
            int rng = Random.Range(0, sprites.Length);
            if (randomizedSprites.Contains(sprites[rng])) continue;
            else 
            {
                randomizedSprites.Add(sprites[rng]);
            }
        }
        randomizedSprites.CopyTo(sprites);

        for (int i = 0; i < sprites.Length; i++) spriteRenderers[i].image.sprite = sprites[i];
    
    }

    public void Click(Button b) 
    {
        Sprite sprite = b.image.sprite;
        if (!playerAnswer.Contains(sprite))
        {
            playerAnswer.Add(sprite);
        }
        else 
        {
            playerAnswer.Remove(sprite);
        }
        UpdateCounters();
    }

    private void UpdateCounters() 
    {

        for(int i = 0; i < sprites.Length; i++) 
        {
            bool on = false;
            int number = 0;
            for (int j = 0; j < playerAnswer.Count; j++) 
            {
                if(sprites[i] == playerAnswer[j]) 
                {
                    on = true;
                    number = j + 1;
                }
            }
            if (on) 
            {
                Counters[i].SetActive(true);
                Counters[i].GetComponentInChildren<Text>().text = number.ToString();
            }
            else 
            {
                Counters[i].SetActive(false);
            }
        }

    }

    public void SubmitAnswer() 
    {
        if(playerAnswer.Count == rightOrder.Length) 
        {
            int hits = 0;
            bool won = false;
            for(int i = 0; i < playerAnswer.Count; i++) 
            {
                if (playerAnswer[i] == rightOrder[i]) hits++;
            }
            if (hits == playerAnswer.Count)
            {
                won = true;
            }
            else 
            {
                won = false;
                FindObjectOfType<ContaminationManager>().gotContaminated(2);
            };
            FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1, won);
        }
    }

}
