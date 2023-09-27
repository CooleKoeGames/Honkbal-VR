using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 30f;
    //public Rigidbody rb;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    /*
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        ScoreManager.scoreCount += 1;

        /*
        Destroy(GetComponent<Rigidbody>());

        Rigidbody ballRigidbody = other.GetComponent<Rigidbody>();
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.useGravity = true;

        rb.velocity = Vector3.zero;
        */
    }
}