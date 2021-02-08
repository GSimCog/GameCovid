using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contextualization : MonoBehaviour
{
    void Update()
    {
        if(GameObject.Find("ContextualizationText").GetComponent<TypeWriter>().currentText == AllTexts.contextualization)
        {
            //gameObject.SetActive(false);
            //GameObject.Find("SceneController").GetComponent<Scenes>().ChangeScene(1);
        }
    }
}
