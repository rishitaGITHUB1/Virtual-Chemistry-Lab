using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
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
    }
    public void hideIt(GameObject obj)
    {
        obj.SetActive(false);
    }
}
