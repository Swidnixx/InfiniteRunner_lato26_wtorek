using UnityEngine;

public class Coin : MonoBehaviour
{
    public float speed = 2;
    Transform player;

    private void Start()
    {
        player = FindAnyObjectByType<Player>().transform;
    }

    private void Update()
    {
        if(GameManager.Instance.MagnetActive)
        {
            float distance = Vector2.Distance(transform.position, player.position);
            if(distance <= GameManager.Instance.MagnetRange)
            transform.position =
                Vector3.MoveTowards(transform.position, 
                    player.position, 
                    speed * Time.deltaTime
                 );
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.Instance.AddCoin();
        }
    }
}
