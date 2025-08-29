using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    public float yFollowConst = 0.3f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, target.transform.position.z + offset.z);
    }
}
