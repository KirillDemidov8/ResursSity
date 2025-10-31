using Resource;
using UnityEngine;

public class PanelSpawn : MonoBehaviour
{
    private GameObject posityonSpawwObcekt;

    [SerializeField] GameObject PeifabTreeFarmer;

    public void GetPosition(GameObject pos)
    {
        posityonSpawwObcekt = pos;
    }


    public void SpawnTreeFarmer()
    {
        GameObject clon = Instantiate(PeifabTreeFarmer, posityonSpawwObcekt.transform.position , Quaternion.identity);

        clon.GetComponent<TreeFarm>().GetResource(Res.tree);
        Destroy(posityonSpawwObcekt);
        
    }
    public void SpawnIronFarmer()
    {
        GameObject clon = Instantiate(PeifabTreeFarmer, posityonSpawwObcekt.transform.position, Quaternion.identity);

        clon.GetComponent<TreeFarm>().GetResource(Res.iron);
        Destroy(posityonSpawwObcekt);
    }
    public void SpawnMedFarmer()
    {
        GameObject clon = Instantiate(PeifabTreeFarmer, posityonSpawwObcekt.transform.position, Quaternion.identity);

        clon.GetComponent<TreeFarm>().GetResource(Res.med);
        Destroy(posityonSpawwObcekt);
    }
}
