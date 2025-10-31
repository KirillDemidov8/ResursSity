using UnityEngine;
using Resource;

public class SpawnFarmer : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    
  

    private void OnMouseDown()
    {
        Panel.SetActive(true);
        Panel.GetComponent<PanelSpawn>().GetPosition(gameObject);

    }

    
    
}
