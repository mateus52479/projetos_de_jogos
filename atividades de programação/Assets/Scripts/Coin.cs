using UnityEngine;

public class Coin : MonoBehaviour
{
    public  GameManager gameManager;

    void Start()
    {
        
    }   

    
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.AddPontos(10);
            Destroy(gameObject);
        }
    }
}
