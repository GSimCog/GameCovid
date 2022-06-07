using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContaminationBarFeedback : MonoBehaviour
{

    private Image sprite;

    private float timer;

    private const float range = 5;

    private void Awake()
    {
        sprite = GetComponent<Image>();
    }

    public void GiveFeedback() { StartCoroutine(ProcessFeedback()); }

    private IEnumerator ProcessFeedback() 
    {

        Color initialColor = sprite.color;

        for(float i = 0; ; i++) 
        {

            float delta = Mathf.Cos(i) * 5;
            sprite.color = new Color(sprite.color.r + delta, sprite.color.g, sprite.color.b);
            timer += Time.deltaTime;
            if (timer >= 5)
            {
                timer = 0;
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }

        sprite.color = initialColor;

    }

}
