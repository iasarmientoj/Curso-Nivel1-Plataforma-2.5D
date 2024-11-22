using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el player entra en el trigger
        if (collision.CompareTag("Player"))
        {

        }
    }
}
