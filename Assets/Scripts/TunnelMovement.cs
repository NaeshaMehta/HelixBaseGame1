using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class TunnelMovement : MonoBehaviour
{
    public float rotspeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotspeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotspeed * Time.deltaTime);
        }
    }
}
