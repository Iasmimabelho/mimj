using TMPro;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    public TMP_Text textoPontos;

    void Update()
    {
        textoPontos.text = "Pontos: " + Moeda.pontos;
    }
}