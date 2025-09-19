using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float speed = 180f; // graus por segundo

    void Update()
    {
        // Gira no eixo Z (ideal pro 2D)
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}