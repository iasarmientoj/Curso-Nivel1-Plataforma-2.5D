using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    [SerializeField]
    private float rotationSpeed = 100f;

    void Update()
    {
        // Rotar alrededor del eje Y (puedes cambiar el eje si es necesario)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
