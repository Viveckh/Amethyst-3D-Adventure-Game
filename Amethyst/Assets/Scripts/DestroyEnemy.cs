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
        Debug.Log("we here");
        Destroy(Enemy, 0.25f);
    }

}
