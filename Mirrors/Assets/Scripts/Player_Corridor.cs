using UnityEngine;
using System.Collections;

public class Player_Corridor : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mirror1") transform.Rotate(Vector3.up * 180);
    }
}
