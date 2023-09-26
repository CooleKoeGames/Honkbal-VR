using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 5f;

    private void Awake()
    {
        Destroy(gameObject, life);
    }
}