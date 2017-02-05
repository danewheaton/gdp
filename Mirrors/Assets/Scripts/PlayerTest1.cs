using UnityEngine;
using System.Collections;

public class PlayerTest1 : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mirror1")
        {
            print("should hit mirror");
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, -transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FallTrigger")
        {
            transform.position = spawnPoint.position;
        }
    }
}
