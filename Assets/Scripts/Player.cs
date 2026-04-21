using UnityEngine;

public class Player : MonoBehaviour
{
    public float force = 100;
    Rigidbody2D rb;

    public int maxJumpCount = 2;
    int usedJumps = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && usedJumps < maxJumpCount)
        {
            //rb.AddForce(new Vector2(0, force));
            rb.linearVelocityY = force;
            usedJumps++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            usedJumps = 0;
    }
}
