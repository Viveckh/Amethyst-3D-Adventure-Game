using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player")){
            c.gameObject.GetComponent<StarterAssets.ThirdPersonController>().GoSlow();
        }			
    }

    private void OnTriggerExit(Collider c)
    {
        if(c.CompareTag("Player")){
            c.gameObject.GetComponent<StarterAssets.ThirdPersonController>().GoFast();
        }			
    }
}
