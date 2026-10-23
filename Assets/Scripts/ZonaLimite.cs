using UnityEngine;
using UnityEngine.SceneManagement;

public class ZonaLimite : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Pared"))
        {
            Debug.Log("¡Te saliste de la zona! Perdiste.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}