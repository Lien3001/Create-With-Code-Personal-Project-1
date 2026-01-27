using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    private float horizontalInput;
    private Rigidbody playerRB;
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
        if (transform.position.x < -13)
        {
            transform.position = new Vector3(-13, 0, -5);
        }
        else if (transform.position.x > 13)
        {
            transform.position = new Vector3(13, 0, -5);
        }
    }

}
