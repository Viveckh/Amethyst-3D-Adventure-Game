using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEnemyDamage : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        GameStats.currentHealth -= 10;

    }

}
