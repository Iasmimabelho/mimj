using UnityEngine;

public class PersonagemController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [Header("Movimento")]
    public float vel = 5f;
    public float forcaPulo = 8f;

    [Header("Ground Check")]
    public GroundCheck groundCheck;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        rb2d.velocity = new Vector2(
            horizontal * vel,
            rb2d.velocity.y
        );

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.noChao)
        {
            rb2d.velocity = new Vector2(
                rb2d.velocity.x,
                forcaPulo
            );
        }

        // Impede sair pelos lados
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -8f, 8f);
        transform.position = pos;
    }
}