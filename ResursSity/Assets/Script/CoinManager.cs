using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    private int coin = 0;

    private void Awake()
    {
        instance = this;
    }

    public void ChangeCountCoin(int count)
    {
        coin += count;

        Debug.Log(coin);
    }

}
