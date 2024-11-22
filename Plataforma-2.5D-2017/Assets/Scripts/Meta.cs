using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject trofeo; // El GameObject que se mostrará al detener el juego

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el player entra en el trigger
        if (collision.CompareTag("Player"))
        {
            // Pausa el juego
            Time.timeScale = 0;

            // Muestra el GameObject
            if (trofeo != null)
            {
                trofeo.SetActive(true);
            }
        }
    }
}
