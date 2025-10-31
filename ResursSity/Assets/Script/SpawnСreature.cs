using Resource;
using UnityEngine;

public class Spawn—reature : MonoBehaviour
{
    private GameObject posityonSpawwObcekt;

    [SerializeField] GameObject PeifabRecycling;

    public void GetPosition(GameObject pos)
    {
        posityonSpawwObcekt = pos;
    }


    public void SpawnBoardFarmer()
    {
        GameObject clon = Instantiate(PeifabRecycling, posityonSpawwObcekt.transform.position, Quaternion.identity);

        clon.GetComponent<—reature>().GetResourceRecycling(Res.musket);
        Destroy(posityonSpawwObcekt);

    }

    public void SpawnCoverageFarmer()
    {
        GameObject clon = Instantiate(PeifabRecycling, posityonSpawwObcekt.transform.position, Quaternion.identity);

        clon.GetComponent<—reature>().GetResourceRecycling(Res.boiler);
        Destroy(posityonSpawwObcekt);

    }

    
}

