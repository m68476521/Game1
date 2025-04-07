using UnityEngine;

public class Player: MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;

    void Start()
    { Debug.Log("Direction: START");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        if (Input.GetMouseButton(0)) 
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // // 1. Get the mouse position in world coordinates
            // Vector3 mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -cam.transform.position.z));

            // // // 2. Calculate the direction to move towards
            // Vector3 direction = (mousePos - rb.position).normalized;

            // // // 3. Apply a force to move the Rigidbody
            // rb.AddForce(direction * moveSpeed, ForceMode2D.Impulse);
            // Debug.Log("Direction: " + direction);
            if (touchPos.x < 0)
            {
                rb.AddForce( Vector2.left * moveSpeed );
            }
            else
            {
                rb.AddForce( Vector2.right * moveSpeed );
            }
            // var mousePos = Input.mousePosition;

            //         mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //         var mouseDir = mousePos - gameObject.transform.position;
            //         mouseDir = new Vector3(mouseDir.x, 0f, mouseDir.z);
            //         mouseDir = mouseDir.normalized;

            //         rb.AddForce((mouseDir) * 1500f * Time.smoothDeltaTime);

                    Debug.Log("Direction: Update");
        }
        else
        {
            Debug.Log("Direction: ELSE");
            rb.velocity = Vector2.zero;
        }
    }

    void FixedUpdate() 
    {

         Debug.Log("Direction: IF");
        // float moveInput = Input.GetAxis("Horizontal");
        // Vector2 movement = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // rb.velocity = movement;

        //     Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        //   if (touchPos.x < 0)
        //     {
        //         rb.AddForce( Vector2.left * moveSpeed );
        //     }
        //     else
        //     {
        //         rb.AddForce( Vector2.right * moveSpeed );
        //     }

    }
//     void FixedUpdate() {
//        float horizontalInput = Input.GetAxis("Horizontal");
//        Vector2 currentVelocity = rb.linearVelocity; // Get current velocity
//        currentVelocity.x = horizontalInput * moveSpeed; // Update x-component
//        rb.velocity = currentVelocity; // Set the new velocity
//    }
}
