using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private bool gravityInverted = false;
    public float movementSpeed = 10f;
    public float gravityMultiplier = 2f;
    private bool isGameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gravityInverted = false;
        Physics.gravity = gravityMultiplier * Vector3.down * 9.81f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver)
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, movementSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityInverted = !gravityInverted;
            Physics.gravity = gravityMultiplier * (gravityInverted ? Vector3.up * 9.81f : Vector3.down * 9.81f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("EndBlock"))
        {
            isGameOver = true;
            Invoke("RestartGame", 2f);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        isGameOver = false;
    }
}
