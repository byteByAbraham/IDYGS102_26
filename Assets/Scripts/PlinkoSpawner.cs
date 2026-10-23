using UnityEngine;
using UnityEngine.InputSystem; // Importante

public class PlinkoSpawner : MonoBehaviour
{
    public GameObject fichaPrefab;
    public float alturaSpawn = 7f;

    void Update()
    {
        // Verificamos si el Mouse izquierdo fue presionado usando el Input System actual
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 posicionMouseScreen = Mouse.current.position.ReadValue();
            Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(posicionMouseScreen);
            posicionMouse.z = 0;
            posicionMouse.y = alturaSpawn;

            Instantiate(fichaPrefab, posicionMouse, Quaternion.identity);
        }
    }
}