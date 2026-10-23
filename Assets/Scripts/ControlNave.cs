using UnityEngine;

public class ControlNave : MonoBehaviour
{
    public float fuerza = 15f;
    private Rigidbody2D rb;
    
    public SpriteRenderer propulsorSprite; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        if (propulsorSprite == null && transform.Find("Propulsor") != null)
        {
            propulsorSprite = transform.Find("Propulsor").GetComponent<SpriteRenderer>();
        }
    }

    void FixedUpdate()
    {
        if (propulsorSprite != null)
        {
            propulsorSprite.color = Color.white;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * fuerza);
            if (propulsorSprite != null) propulsorSprite.color = Color.red; 
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * fuerza);
            if (propulsorSprite != null) propulsorSprite.color = Color.green; 
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * fuerza);
            if (propulsorSprite != null) propulsorSprite.color = Color.yellow; 
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector2.down * fuerza);
            if (propulsorSprite != null) propulsorSprite.color = Color.blue;
        }
    }
}