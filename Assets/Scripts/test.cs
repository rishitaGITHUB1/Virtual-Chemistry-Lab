using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject objec;
    void Start()
    {
        if (objec.activeSelf == true)
        {
            objec.SetActive(false);
        }
    }
    public void showIt(GameObject obj)
    {

        obj.SetActive(true);
        StartCoroutine(RemoveAfterSeconds(2));
    }
    IEnumerator RemoveAfterSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        gameObject.SetActive(false);
    }
}
