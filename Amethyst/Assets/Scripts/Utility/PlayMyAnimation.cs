using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour
{
    public Animator myAnimationControllerLid;
    public Animator myAnimationControllerPlatform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        
        if(other.CompareTag("Player")) {
            myAnimationControllerLid.SetBool("OpenChest", true);
            myAnimationControllerPlatform.SetBool("PlatformRises", true);
        }
    }

    private void OnTriggerExit(Collider other){
        
        if(other.CompareTag("Player")) {
            myAnimationControllerLid.SetBool("OpenChest", false);
            myAnimationControllerPlatform.SetBool("PlatformRises", false);
        }
    }
}
