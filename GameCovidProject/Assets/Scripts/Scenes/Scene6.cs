using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6 : MonoBehaviour
{
    [SerializeField] GameObject[] people;
    [SerializeField] private Sprite[] personSp;
    private int withoutMask;
    public float timePassed = 0;
    private float totalPeople = 0;
    public bool isWithoutMask = false;

    public GameObject putMask;

    void Update()
    {
        timePassed += Time.deltaTime;

        if(timePassed >= 3)
        {
            if(!isWithoutMask)
            {
                RandomPerson();
            }
        }

        if (totalPeople >= 4 && !isWithoutMask)
        {
            FindObjectOfType<Scenes>().EndLevel(PlayerPrefs.GetInt("ActualScene") + 1);
        }
    }

    private void RandomPerson()
    {
        withoutMask = Random.Range(0, 4);
        people[withoutMask].GetComponent<SpriteRenderer>().sprite = personSp[0];
        GameObject gObj = Instantiate(putMask, new Vector3(people[withoutMask].GetComponent<Transform>().position.x, 0.83f, 0), Quaternion.identity);
        gObj.GetComponent<PutMaskBehavior>().person = people[withoutMask];
        gObj.GetComponent<PutMaskBehavior>().scene = GetComponent<Scene6>();
        isWithoutMask = true;
        totalPeople += 1;
    }
}
