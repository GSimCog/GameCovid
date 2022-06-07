using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutMask : MonoBehaviour
{

    [SerializeField]
    private float minigameTime;

    private float timer;

    [SerializeField]
    private float maskActivationInterval;

    private float activationTimer;

    [SerializeField]
    private MaskState[] masks;

    private void Update()
    {
        timer += Time.deltaTime;
        activationTimer += Time.deltaTime;
        if(timer >= minigameTime) 
        {
            Stop();
            FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1, true, "Você conseguiu manter a ordem na fila e todos estão seguros! Vamos prosseguir!");
        }

        if(activationTimer >= maskActivationInterval) 
        {
            activationTimer = 0;
            int rnd = Random.Range(0, masks.Length);
            masks[rnd].TakeOut();
        }

    }

    public void Stop() 
    {

        foreach (MaskState m in masks) m.gameObject.SetActive(false);

    }

}
