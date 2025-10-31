using UnityEngine;
using System.Collections;
using System;
using Resource;
public class Recycling : MonoBehaviour
{
    private Resurs resurs;
    
    int costBoards =  10;
    int costCoverage = 20;
    int costPipes = 20;
    int resPlus = 5;

    Res resouce;


    void Start()
    {
        resurs = GameObject.Find("Resurs").GetComponent<Resurs>();
        StartCoroutine(Timer());
    }

    public void GetResourceRecycling( Res r)
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
            case "boart":
                RecyclingResBoard();
                break;

            case "coverage":
                RecyclingResCoverage();
                break;

            case "pipes":
                RecyclingResPipes();
                break;
        }
    }

    public void RecyclingResBoard()
    {
        if (resurs.ChekTreeCount(costBoards))
        {
            resurs.UpdadeTreeResurs(-costBoards);
            resurs.UpdateBoardResurs(resPlus);
        }
    }
    public void RecyclingResCoverage()
    {
        if (resurs.ChekTreeCount(costCoverage))
        {
            resurs.UpdadeIronResurs(-costCoverage);
            resurs.UpdateCoverageResurs(resPlus);
        }
    }

    public void RecyclingResPipes()
    {
        if (resurs.CheMedCount(costPipes))
        {

            resurs.UpdadeMedResurs(-costPipes);
            resurs.UpdatePipeseResurs(resPlus);
        }
    }
    
}
