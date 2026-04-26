using UnityEngine;

public class FoxMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int speed = 10;
    public bool canJump = true;
    public int jumpForce = 450;

    private Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        
    }
    private void FixedUpdate()
    {
        jump();
    }

    private void jump() {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Platform"))
        {
            canJump = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Platform"))
        {
            canJump = false;
        }

    }
}
