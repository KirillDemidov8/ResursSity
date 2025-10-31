using Resource;
using UnityEngine;

public class PanelRescylingSpawner : MonoBehaviour
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

        clon.GetComponent<Recycling>().GetResourceRecycling( Res.boart);
        Destroy(posityonSpawwObcekt);

    }

    public void SpawnCoverageFarmer()
    {
        GameObject clon = Instantiate(PeifabRecycling, posityonSpawwObcekt.transform.position, Quaternion.identity);

        clon.GetComponent<Recycling>().GetResourceRecycling(Res.coverage);
        Destroy(posityonSpawwObcekt);

    }

    public void SpawnPipesFarmer()
    {
        GameObject clon = Instantiate(PeifabRecycling, posityonSpawwObcekt.transform.position, Quaternion.identity);

        clon.GetComponent<Recycling>().GetResourceRecycling(Res.pipes);
        Destroy(posityonSpawwObcekt);

    }
}
