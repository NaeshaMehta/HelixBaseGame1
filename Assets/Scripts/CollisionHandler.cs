using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public PlayerMovement playerMovementScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("EndBlock"))
        {
            Invoke("RestartGame", 2f);
            playerMovementScript.enabled = false;
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("BaseGame");
        playerMovementScript.enabled = true;
    }
}
