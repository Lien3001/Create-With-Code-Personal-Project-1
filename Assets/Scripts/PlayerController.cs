using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    private float horizontalInput;
    private Rigidbody playerRB;
    private float leftLimit = -13.0f;
    private float rightLimit = 13.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        limitPlayerMovement();
        movePlayer();

    }

    void movePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
    }

    void limitPlayerMovement()
    {
        if (transform.position.x < leftLimit)
        {
            transform.position = new Vector3(leftLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > rightLimit)
        {
            transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);
        }
    }

}
