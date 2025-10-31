using Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShopController : DictShopCosts
{
    public static ShopController instance;
    //загрузка ресурсов для продажи
    [SerializeField] private GameObject prefabSlotRes;
    [SerializeField] private Transform scroll;

    [SerializeField] private PanelSell panelSell;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        LoadShopResources();
    }

    public void LoadShopResources()
    {
        List<string> res =  Enum.GetNames(typeof(Res)).ToList();
        foreach (var r in res)
        {
            GameObject clone = Instantiate(prefabSlotRes, scroll);
            clone.name = r;
        }
    }

    public void OpenPanelShopSellRes(string type)
    {
        panelSell.gameObject.SetActive(true);
        panelSell.TypeRes(type);
    }
}
