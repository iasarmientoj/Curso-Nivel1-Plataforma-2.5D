using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneda : MonoBehaviour {

    // Velocidad de rotación en grados por segundo
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private AudioClip sonidoMoneda;

    void Update()
    {
        // Rotar alrededor del eje Y (puedes cambiar el eje si es necesario)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        //obtener puntaje actual
        GameObject[] puntaje = GameObject.FindGameObjectsWithTag("puntaje");

        int puntajeInt = int.Parse(puntaje[0].GetComponent<Text>().text);

        Debug.Log(puntajeInt);


        //sumarle 1
        puntajeInt++;


        //actualizar puntaje
        foreach (GameObject p in puntaje)
        {
            p.GetComponent<Text>().text = puntajeInt.ToString("0000");
        }



        GetComponent<AudioSource>().PlayOneShot(sonidoMoneda);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;


        Invoke("DeleteMoneda", 2f);
    }


    private void DeleteMoneda()
    {
        Destroy(gameObject);

    }

}
