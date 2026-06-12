using UnityEngine;

public class Moeda : MonoBehaviour
{
    public static int pontos = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            pontos++;
            Destroy(gameObject);

            Debug.Log("Pontos: " + pontos);
        }
    }
}