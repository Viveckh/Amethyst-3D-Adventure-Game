using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHeathTokens : MonoBehaviour
{
    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider other)
    {
        GameStats.currentHealth += 10;
        Destroy(gameObject);

    }




}
