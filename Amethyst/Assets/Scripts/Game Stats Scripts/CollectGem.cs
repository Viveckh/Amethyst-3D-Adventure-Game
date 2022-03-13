using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{ // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        GameStats.numberOfGemsCollected += 1;
        Destroy(gameObject);
        FindObjectOfType<AudioManager>().Play("gem-collected");

    }
}
