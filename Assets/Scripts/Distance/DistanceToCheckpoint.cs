using UnityEngine;
using UnityEngine.UI;

public class DistanceToCheckpoint : MonoBehaviour
{
    [SerializeField] private Transform checkpoint;

    [SerializeField] private Text distanceText;

    private float distance;

    private void Update()
    {
        distance = (checkpoint.transform.position - transform.position).magnitude;

        distanceText.text = "Distance: " + distance.ToString("F1") + " meters";
    }
}