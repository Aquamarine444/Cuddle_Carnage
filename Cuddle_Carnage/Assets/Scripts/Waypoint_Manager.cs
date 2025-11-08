using System.Xml.Serialization;
using Unity.Cinemachine;
using UnityEngine;

public class Waypoint_Manager : MonoBehaviour
{
    [SerializeField] PolygonCollider2D MapBoundary;
    public CinemachineConfiner2D confiner;

    [SerializeField] Direction direction;
    [SerializeField] float additivePosition = 2;

    enum Direction {Up, Down, Left, Right}

    public GameObject PreviousSound;
    public GameObject NextSound;

    private void Awake()
    {
        confiner = FindObjectOfType<CinemachineConfiner2D>();
    }

    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 newPosition = player.transform.position;

        switch (direction)
        {
            case Direction.Up:
            newPosition.y += additivePosition;
            break;

            case Direction.Down:
            newPosition.y -= additivePosition;
            break;

            case Direction.Left:
            newPosition.x += additivePosition;
            break;

            case Direction.Right:
            newPosition.x -= additivePosition;
            break;
        }

        player.transform.position = newPosition;
        PreviousSound.SetActive(false);
        NextSound.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            confiner.BoundingShape2D = MapBoundary;

            UpdatePlayerPosition(collision.gameObject);
        }
    }
}
