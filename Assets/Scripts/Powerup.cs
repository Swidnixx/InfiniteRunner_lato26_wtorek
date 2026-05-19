using UnityEngine;

public abstract class Powerup : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            Activate();
        }
    }

    protected virtual void Activate()
    {

    }
}
