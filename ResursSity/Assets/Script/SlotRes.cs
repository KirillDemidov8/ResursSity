using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotRes : MonoBehaviour
{
    [SerializeField] private Image img;
    [SerializeField] private TextMeshProUGUI costText;
    void Start()
    {
        img.sprite = Resources.Load<Sprite>(gameObject.name);
        if (ShopController.instance.IsKeyInDic(gameObject.name))
        {
            costText.text = ShopController.instance.GetCost(gameObject.name).ToString();
        }
    }

    public void ChoiceRes()
    {
        ShopController.instance.OpenPanelShopSellRes(gameObject.name);
    }
}
