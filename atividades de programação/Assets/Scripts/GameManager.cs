using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int pontos = 0;
    public int vidas = 3;
    public TextMeshProUGUI textPontos;

    public void AddPontos(int  qtd)
    {
        pontos += qtd;

        if (pontos < 0)
        {
            pontos = 0;
        }
        textPontos.text = "pontos: " + pontos;

        Debug.Log("pontos: " + pontos);
    }

    public void alteraVidas(int vida)
    { 
        vidas -= vida;

        if (vidas <= 0)
        {
            vidas = 0;
            Time.timeScale = 0;
            Debug.Log("HAHHAHAHA VOCE PERDEU");
        }
        Debug.Log("vidas: " + vidas);

        GameObject player = GameObject.FindWithTag("Player");
        player.GetComponent<Player>().reiniciar_posicao();
    
    }


}
