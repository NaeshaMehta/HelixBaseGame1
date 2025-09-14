using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0,0,-7);
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z + offset.z);
    }
}