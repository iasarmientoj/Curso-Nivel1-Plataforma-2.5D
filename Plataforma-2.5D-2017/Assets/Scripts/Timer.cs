using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float startTime = 180f; // Tiempo inicial en segundos
    private float currentTime;    // Tiempo actual

    private void Start()
    {
        currentTime = startTime;
    }

    private void Update()
    {
        // Reduce el tiempo actual
        currentTime -= Time.deltaTime;

        // Asegúrate de que no sea menor a 0
        currentTime = Mathf.Max(currentTime, 0);

        // Actualiza los textos con el tag "timer"
        UpdateTimerText();

        // Si el tiempo llega a 0, recarga la escena 1
        if (currentTime <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    private void UpdateTimerText()
    {
        // Busca todos los objetos con el tag "timer"
        GameObject[] timerObjects = GameObject.FindGameObjectsWithTag("timer");

        foreach (GameObject timerObject in timerObjects)
        {
            // Intenta obtener un componente de texto (puede ser Text o TextMeshPro)
            var textComponent = timerObject.GetComponent<Text>();

            if (textComponent != null)
            {
                textComponent.text = Mathf.CeilToInt(currentTime).ToString();
            }
        }
    }
}

