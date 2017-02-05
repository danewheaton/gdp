using UnityEngine;
using System.Collections;

public class Player_Corridor : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mirror1")
        {
            print("should hit mirror");
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, -transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }
}
