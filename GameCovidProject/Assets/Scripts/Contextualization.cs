using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contextualization : MonoBehaviour
{
    void Update()
    {
        if(GameObject.Find("ContextualizationText").GetComponent<TypeWriter>().currentText == AllTexts.contextualization)
        {
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Teste");
            }
            //gameObject.SetActive(false);
            //GameObject.Find("SceneController").GetComponent<Scenes>().ChangeScene(1);
        }
    }
}
