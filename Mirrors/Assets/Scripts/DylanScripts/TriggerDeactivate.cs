using UnityEngine;
using System.Collections;

public class TriggerDeactivate : MonoBehaviour {


    public GameObject[] m_DeactivatedObjects;

	// Use this for initialization
	void Start ()
    {
        MeshRenderer meshRender = this.gameObject.GetComponent<MeshRenderer>();
        //Make self invisible
        meshRender.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < m_DeactivatedObjects.Length; i++)
        {
            m_DeactivatedObjects[i].SetActive(false);
        }
    }
}
