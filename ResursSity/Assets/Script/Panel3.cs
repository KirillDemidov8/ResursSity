using UnityEngine;
using Resource;
public class Panel3 : MonoBehaviour
{
    [SerializeField] GameObject Panel;



    private void OnMouseDown()
    {
        Panel.SetActive(true);
        Panel.GetComponent<SpawnÑreature>().GetPosition(gameObject);

    }
}
