using UnityEngine;
using System.Collections;

public class Player_Corridor : MonoBehaviour
{
    [SerializeField] Material materialToChange;
    [SerializeField] GameObject[] rooms;

    NonUFPSPlayerController controller;
    float originalSpeed;
    int counter;

    void Start()
    {
        materialToChange.color = new Color(.6f, .6f, .3f);
        controller = GetComponent<NonUFPSPlayerController>();
        originalSpeed = controller.movementSpeed;
    }

    void Update()
    {
        if (Input.GetAxis("Vertical") <= 0) controller.movementSpeed = originalSpeed;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mirror1")
        {
            transform.Rotate(Vector3.up * 180);
            transform.position += new Vector3(10, 0, 0);
            controller.movementSpeed *= 1.075f;
            if (controller.movementSpeed >= 20) controller.movementSpeed = 20;
            counter++;
            if (counter < rooms.Length) rooms[counter].SetActive(true);
            rooms[counter - 1].SetActive(false);

            Color newColor = new Color(materialToChange.color.r + .025f, materialToChange.color.g - .0125f, materialToChange.color.b - .0125f);
            materialToChange.color = newColor;
        }
    }
}
