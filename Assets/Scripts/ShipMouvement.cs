using UnityEngine;

public class ShipMouvement : MonoBehaviour
{
    public float speed; // Speed of the ship
    Vector2 move;
    Rigidbody2D rb;// Vector2 to store the movement

    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rb.position.x > 3.5f)
        {
            rb.position = new Vector2(3.5f, rb.position.y);
        }
        if (rb.position.x < -3.5f)
        {
            rb.position = new Vector2(-3.5f, rb.position.y);
        }
        if (rb.position.y > 1.55f)
        {
            rb.position = new Vector2(rb.position.x, 1.55f);
        }
        if (rb.position.y < -1.55f)
        {
            rb.position = new Vector2(rb.position.x, -1.55f);
        }
        
        rb.linearVelocity = new Vector2(move.x * speed * Time.deltaTime, move.y * speed * Time.deltaTime);
        
        animator.SetFloat("speed", rb.linearVelocity.y);


    }
    // FixedUpdate est appelé à chaque frame de physique
    void Update()
    {
        
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
