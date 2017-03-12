using UnityEngine;
using System.Collections;

public class TriggerActivate : MonoBehaviour
{


    public GameObject[] m_ActivatedObjects;

    // Use this for initialization
    void Start()
    {
        MeshRenderer meshRender = this.gameObject.GetComponent<MeshRenderer>();
        //Make self invisible
        meshRender.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < m_ActivatedObjects.Length; i++)
        {
            m_ActivatedObjects[i].SetActive(true);
        }
    }
}
