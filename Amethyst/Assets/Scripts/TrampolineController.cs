using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision c)
    {
        /*
        if (c.gameObject.tag == "Player")
        {
            c.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
        }
        */
        if (c.gameObject != null && c.gameObject.GetComponent<Rigidbody>() != null)
        {
            c.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 40000);
        }
    }   
}
