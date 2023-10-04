using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private Transform origin;
    [SerializeField] private Vector3 cubeSize = new Vector3(1f, 1f, 1f);

    [SerializeField] private float lineEndPointRadius = 0.1f;
    [SerializeField] private float distance = 1f;
    private Vector3 greenLineEndPoint = new Vector3();

    [SerializeField] private Transform refObject;
    [SerializeField] private float refObjectSize = 0.1f;

    public float t = 0f;

    private Vector3 intersection = new Vector3();
    [SerializeField] private float intersectionSize = 0.05f;

    public float distanceToGreenline = 0f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(origin.position, cubeSize);

        greenLineEndPoint = origin.position + (origin.forward * distance);

        Gizmos.DrawRay(origin.position, greenLineEndPoint - origin.position);
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(greenLineEndPoint, lineEndPointRadius);

        Gizmos.color = Color.magenta;
        Gizmos.DrawSphere(refObject.position, refObjectSize);

        t = ((refObject.position.x - greenLineEndPoint.x) * (origin.position.x - greenLineEndPoint.x) +
            (refObject.position.y - greenLineEndPoint.y) * (origin.position.y - greenLineEndPoint.y) +
            (refObject.position.z - greenLineEndPoint.z) * (origin.position.z - greenLineEndPoint.z)) / (distance * distance);

        t = Mathf.Clamp(t, 0f, 1f);

        intersection.x = greenLineEndPoint.x + t * (origin.position.x - greenLineEndPoint.x);
        intersection.y = greenLineEndPoint.y + t * (origin.position.y - greenLineEndPoint.y);
        intersection.z = greenLineEndPoint.z + t * (origin.position.z - greenLineEndPoint.z);

        Gizmos.color = Color.red;
        Gizmos.DrawRay(refObject.position, intersection - refObject.position);
        Gizmos.DrawSphere(intersection, intersectionSize);

        distanceToGreenline = Vector3.Distance(refObject.position, intersection);
    }
}