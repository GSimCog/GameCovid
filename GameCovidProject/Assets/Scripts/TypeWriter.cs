using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriter : MonoBehaviour
{
    private float delay = 0.03f;
    public string currentText = "";
    [TextAreaAttribute(0, 5)] public string fullText;

    void Start()
    {
        fullText = AllTexts.contextualization;
        StartCoroutine(ShowText());
    }

    public IEnumerator ShowText()
    {
        for(int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}
