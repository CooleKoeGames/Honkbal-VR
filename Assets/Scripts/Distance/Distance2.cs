using UnityEngine;

public class Distance2 : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public float Distance_;

    private void Update()
    {
        Distance_ = Vector3.Distance(Cube1.transform.position, Cube2.transform.position);
    }
}