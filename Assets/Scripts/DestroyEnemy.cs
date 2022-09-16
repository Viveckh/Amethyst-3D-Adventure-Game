using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
    }


    void OnTriggerEnter(Collider other){
        FindObjectOfType<AudioManager>().Play("squish");
        KyleKiller killer = Enemy.GetComponent<KyleKiller>();

        if (killer != null)
        {
            killer.markDead();
            Destroy(Enemy, 3f);

        }
    }

}
