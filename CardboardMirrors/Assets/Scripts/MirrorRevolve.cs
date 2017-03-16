using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum directionState { left, right, up, down }

public class MirrorRevolve : MonoBehaviour
{
    [SerializeField]
    directionState rotationDirection;

    [SerializeField]
    float speed = 2;

    Vector3 direction;

    private void Start()
    {
        switch (rotationDirection)
        {
            case directionState.left:
                direction = Vector3.down;
                break;
            case directionState.right:
                direction = Vector3.up;
                break;
            case directionState.up:
                direction = Vector3.left;
                break;
            case directionState.down:
                direction = Vector3.right;
                break;
        }
    }

    private void Update()
    {
        transform.Rotate(direction * speed * Time.deltaTime);
    }
}
