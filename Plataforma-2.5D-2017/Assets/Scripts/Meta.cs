using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject trofeo; // El GameObject que se mostrará al detener el juego
    public AudioSource musicaFondo; // El AudioSource de la música externa
    public AudioClip sonidoGanador; // El AudioSource interno para el festejo

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

            // Pausa la música
            if (musicaFondo != null && musicaFondo.isPlaying)
            {
                musicaFondo.Pause();
            }

            // Reproduce el festejo
            GetComponent<AudioSource>().PlayOneShot(sonidoGanador);
        }
    }
}
