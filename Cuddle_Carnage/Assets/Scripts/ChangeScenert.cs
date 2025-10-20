using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeScenert : MonoBehaviour
{
    public Vector3 CaveEntrance;
    public Vector3 CaveExit;

    public bool InsideCave;
    public bool OutsideCave;

    [SerializeField] PolygonCollider2D MapBoundary;
    public CinemachineConfiner2D confiner;

    public void UpdatePosition(GameObject player)
    {
        Vector3 newPosition = player.transform.position;

        if (InsideCave)
        {
            newPosition = CaveEntrance;
        }

        if (OutsideCave)
        {
            newPosition = CaveExit;
        }

        player.transform.position = newPosition;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            confiner.BoundingShape2D = MapBoundary;

            UpdatePosition(collision.gameObject);
        }
    }
}
