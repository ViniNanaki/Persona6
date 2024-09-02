using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Events : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject igor;
    public GameObject textBox;

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(4);
        fadeScreenIn.SetActive(false);
        igor.SetActive(true);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
    }

}
