using UnityEngine;
using UnityEngine.SceneManagement;

public class Player: MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        if (Input.GetMouseButton(0)) 
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x < 0)
            {
                rb.AddForce( Vector2.left * moveSpeed );
            }
            else
            {
                rb.AddForce( Vector2.right * moveSpeed );
            }
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collition)
    {
        if (collition.gameObject.tag == "Block")
        {
            SceneManager.LoadScene("Game"); // or 0
        }
    }
}
