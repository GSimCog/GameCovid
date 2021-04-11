using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTheRightOrder : MonoBehaviour
{
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private List<Button> buttons;

    void Start()
    {
        sprites.Add(Resources.Load<Sprite>("Minigames/ChooseRightOrder"));
    }

    void Update()
    {
        
    }
}
