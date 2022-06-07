using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskState : MonoBehaviour
{

    [SerializeField]
    private int maskState;

    [SerializeField]
    private GameObject mask1;

    [SerializeField]
    private GameObject mask2;

    private float timer;

    private void Update()
    {
        if(maskState == 0) 
        {
            mask1.SetActive(true);
            mask2.SetActive(false);
            timer = 0;
        }
        else 
        {
            mask1.SetActive(false);
            mask2.SetActive(true);
            timer += Time.deltaTime;
            if(timer >= 5) 
            {
                FindObjectOfType<ContaminationManager>().gotContaminated(2);
                FindObjectOfType<PutMask>().Stop();
                FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1, false, "Um dos pacientes ficou tempo demais sem a máscara. Vamos prosseguir!");
            }
        }
    }

    public void TakeOut() { maskState = 1; }
    public void PutIn() { maskState = 0; }

}
