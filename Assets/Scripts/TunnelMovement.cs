using UnityEngine;

public class TunnelMovement : MonoBehaviour
{
    public float rotspeed = 90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -rotspeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 0f, rotspeed * Time.deltaTime);
        }
    }
}
