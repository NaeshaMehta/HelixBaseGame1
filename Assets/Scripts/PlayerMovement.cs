using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private bool gravityInverted = false;
    public float movementSpeed = 10f;
    public float gravityMultiplier = 2f;
    private bool isGameOver;
    public TMP_Text scoreMessage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity = gravityMultiplier * Vector3.down * 9.81f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
            return;
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, movementSpeed);  
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityInverted = !gravityInverted;
            Vector3 direction;
            if(gravityInverted == true)
                direction = Vector3.up;
            else
                direction = Vector3.down;
            Physics.gravity = 9.81f * gravityMultiplier * direction;
        }
        scoreMessage.text = "Score: " + ComputeScore();
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
        SceneManager.LoadScene("BaseGame");
        isGameOver = false;
    }
    private int ComputeScore()
    {
        return Mathf.RoundToInt(transform.position.z);
    }
}
