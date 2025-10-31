using UnityEngine;
using Resource;
public class SpawnRecycling : MonoBehaviour
{
    [SerializeField] GameObject Panel2;



    private void OnMouseDown()
    {
        Panel2.SetActive(true);
        Panel2.GetComponent<PanelRescylingSpawner>().GetPosition(gameObject);

    }
}
