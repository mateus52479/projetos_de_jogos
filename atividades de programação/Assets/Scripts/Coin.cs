using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int pontos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pontos++;
            Debug.Log(pontos);
        }
    }
}
