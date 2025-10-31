using UnityEngine;

public class ButtonShop : MonoBehaviour
{
    [SerializeField] GameObject Panel;



    public void ButtonShopOpen()
    {
        Panel.SetActive(true);
    }
    public void ButtonShopClose()
    {
        Panel.SetActive(false);
    }
}
