using System.Collections.Generic;
using UnityEngine;

public class DictShopCosts : MonoBehaviour
{
    public static Dictionary<string, int> Costs()
    {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        dict.Add("tree", 2);
        dict.Add("iron", 10);
        dict.Add("med", 5);

        dict.Add("boart", 10);
        dict.Add("coverage", 20);
        dict.Add("pipes", 15);

        return dict;
    }

    private Dictionary<string, int> dicCosts = Costs();

    public int GetCost(string key)
    {
        return dicCosts[key];
    }

    public bool IsKeyInDic(string key)
    {
        return dicCosts.ContainsKey(key);
    }
}
