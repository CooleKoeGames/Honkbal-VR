using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }
}