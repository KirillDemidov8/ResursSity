using UnityEngine;
using TMPro;
using System;
using Resource;

public class PanelSell : MonoBehaviour
{
    [SerializeField] private Resurs resurs;
    [SerializeField] private TMP_InputField input;
    [SerializeField] private TextMeshProUGUI costText;
    private string typeRes;
    private int costOfOne;

    public void TypeRes(string type)
    {
        typeRes = type;
        costOfOne = ShopController.instance.GetCost(typeRes);
    }

    public void EndWriteCount()
    {
        if (input.text.Length > 0)
        {
            int cost = Convert.ToInt32(input.text) * costOfOne;
            costText.text = cost.ToString();
        }
    }

    public void SellRes()
    {
        int count = Convert.ToInt32(input.text);
        if (resurs.IsCanSell(typeRes, count))
        {
            resurs.ChangeRes(typeRes, -count);
            int costSell = Convert.ToInt32(input.text) * costOfOne;
            CoinManager.instance.ChangeCountCoin(costSell);
        }
    }
}
