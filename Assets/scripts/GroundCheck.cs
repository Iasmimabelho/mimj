using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public LayerMask groundLayer;

    [HideInInspector]
    public bool noChao;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            noChao = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            noChao = false;
        }
    }
}