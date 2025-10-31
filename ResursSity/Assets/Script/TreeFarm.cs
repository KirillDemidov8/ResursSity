using UnityEngine;
using System.Collections;
using System;
using Resource;

public class TreeFarm : MonoBehaviour
{
    private Resurs resurs;

    
    int resPlus = 10;
    Res resouce;

    void Start()
    {
        resurs = GameObject.Find("Resurs").GetComponent<Resurs>();
        StartCoroutine(Timer());
    }

    public void GetResource(Res r)
    {
        resouce = r;
    }

    IEnumerator Timer()
    {
        for (; ; )
        {
            Farm();
            yield return new WaitForSeconds(5);
        }
    }

    public void Farm()
    {
        resurs.ChangeRes(resouce.ToString(),resPlus);
    }



}
