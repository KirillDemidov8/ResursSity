using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    Vector3 position1 = new Vector3(0, 0, -10);
    Vector3 position2 = new Vector3(22, 0, -10);
    Vector3 position3 = new Vector3(44, 0, -10);


    public void MovecamersPosityon1()
    {
        transform.position = position1;
    }
    public void MovecamersPosityon2()
    {
        transform.position = position2;
    }
    public void MovecamersPosityon3()
    {
        transform.position = position3;
    }
}
