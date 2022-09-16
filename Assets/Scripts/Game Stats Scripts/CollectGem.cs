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

        // Disable the marker of collected gem and barriers to the next level
        if (GameStats.numberOfGemsCollected == 1)
        {
            GameObject.Find("gemBeam1").SetActive(false);
            GameObject.Find("Level2Barrier").SetActive(false);
        }
        else if (GameStats.numberOfGemsCollected == 2) {
            GameObject.Find("gemBeam2").SetActive(false);
            GameObject.Find("Level3Barrier").SetActive(false);
        }
        else if (GameStats.numberOfGemsCollected == 3)
        {
            GameObject.Find("gemBeam3").SetActive(false);
            GameObject.Find("Level4Barrier").SetActive(false);
        }
        else if (GameStats.numberOfGemsCollected == 4)
        {
            GameObject.Find("gemBeam4").SetActive(false);
        }

    }
}
