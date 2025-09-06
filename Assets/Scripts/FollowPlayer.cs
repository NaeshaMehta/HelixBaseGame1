using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target;
    public float offset = -7f;
    private Vector3 cameraLocation = new Vector3();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cameraLocation = transform.position;
        cameraLocation.z = target.transform.position.z + offset;
        transform.position = cameraLocation;
    }
}