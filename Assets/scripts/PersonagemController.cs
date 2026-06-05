using UnityEngine;

public class PersonagemController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float vel = 5f;
    public float forcaPulo = 8f;

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask groundLayer;

    private bool noChao;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Verifica se está no chão
        noChao = Physics2D.OverlapCircle(
            groundCheck.position,
            groundRadius,
            groundLayer
        );

        // Movimento horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(
            horizontalInput * vel,
            rb2d.velocity.y
        );

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb2d.velocity = new Vector2(
                rb2d.velocity.x,
                forcaPulo
            );
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(
                groundCheck.position,
                groundRadius
            );
        }
    }
}