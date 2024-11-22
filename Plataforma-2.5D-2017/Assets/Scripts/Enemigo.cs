using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    public float moveDistance = 5f; // Distancia de movimiento
    public float moveSpeed = 2f;   // Velocidad de movimiento
    private Vector2 startPosition; // Posición inicial
    private bool movingRight = true; // Dirección de movimiento

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        Patrol();
    }

    private void Patrol()
    {
        // Calcula la posición objetivo
        float targetX = startPosition.x + (movingRight ? moveDistance : -moveDistance);
        float step = moveSpeed * Time.deltaTime;

        // Mueve el objeto hacia el objetivo
        transform.position = new Vector2(Mathf.MoveTowards(transform.position.x, targetX, step), transform.position.y);

        // Cambia de dirección al alcanzar los límites
        if (Mathf.Abs(transform.position.x - targetX) < 0.1f)
        {
            movingRight = !movingRight;
            Flip();
        }
    }

    private void Flip()
    {
        // Invierte el localScale en el eje X
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el player entra en el trigger
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(1); // Recarga la escena 1
        }
    }
}
