using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> names;
    private Queue<string> sentences;

    [SerializeField] private Text sentenceText;
    public bool endDialogue;

    private void Awake()
    {
        names = new Queue<string>();
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        names.Clear();
        sentences.Clear();

        foreach(string name in dialogue.name)
        {
            names.Enqueue(name);
        }
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string name = names.Dequeue();
        string sentence = sentences.Dequeue();

        StopAllCoroutines();
        StartCoroutine(TypeSentence(name, sentence));
    }

    IEnumerator TypeSentence(string name, string sentence)
    {
        sentenceText.text = name + ": ";
        foreach(char letter in sentence.ToCharArray())
        {
            sentenceText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("A conversa terminou.");
        endDialogue = true;
    }
}
