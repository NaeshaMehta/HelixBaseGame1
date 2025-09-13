using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private bool gravityInverted = false;
    public float gravityMultiplier = 2f;
    public float movementSpeed = 10f;
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
        float gravityValue = 9.81f * gravityMultiplier;
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, movementSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravityInverted = !gravityInverted;
            if(gravityInverted == true)
                Physics.gravity = gravityValue * Vector3.up;
            else
                Physics.gravity = gravityValue * Vector3.down;
        }
        scoreMessage.text = "Score: " + ComputeScore();
    }
    private int ComputeScore()
    {
        return Mathf.RoundToInt(transform.position.z);
    }
}
