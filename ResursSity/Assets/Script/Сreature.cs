using UnityEngine;
using System.Collections;
using System;
using Resource;

public class Сreature : MonoBehaviour
{
    private Resurs resurs;

    int costBoards = 20;
    int costCoverage = 20;
    //int costPipes = 20;
    //int resPlus = 1;

    Res resouce;


    void Start()
    {
        resurs = GameObject.Find("Resurs").GetComponent<Resurs>();
        StartCoroutine(Timer());
    }

    public void GetResourceRecycling(Res r)
    {
        resouce = r;
    }

    IEnumerator Timer()
    {
        for (; ; )
        {
            RecyclingRes();
            yield return new WaitForSeconds(5);
        }
    }

    public void RecyclingRes()
    {
        switch (resouce.ToString())
        {
            case "boiler":
                RecyclingResBoiler();
                break;

            case "musket":
                RecyclingResMusket();
                break;

            
        }
    }

    public void RecyclingResMusket()
    {
        if (resurs.ChekTreeCount(costBoards) )
        {
            
           // resurs.UpdadeTreeResurs(-costBoards);
           // resurs.UpdateBoardResurs(resPlus);
        }
    }
    public void RecyclingResBoiler()
    {
        if (resurs.ChekTreeCount(costCoverage))
        {
           // resurs.UpdadeIronResurs(-costCoverage);
           // resurs.UpdateCoverageResurs(resPlus);
        }
    }

    
}
