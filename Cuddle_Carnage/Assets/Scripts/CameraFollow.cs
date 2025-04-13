using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    public float Smoothing = 5.0f;
    private Vector3 Offset;

    private void Start()
    {
        Offset = transform.position - Player.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = Player.transform.position + Offset;

        transform.position = Vector3.Lerp(transform.position, targetPosition, Smoothing * Time.deltaTime);
    }
}
