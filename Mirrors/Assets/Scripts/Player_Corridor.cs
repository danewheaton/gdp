using UnityEngine;
using System.Collections;

public class Player_Corridor : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.tag == "Mirror1")
        {
            //transform.Rotate()
            print("should hit mirror");
        }
    }
}
