using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyStrokesHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // starting the game in paused mode
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            // if paused, then start game, otherwise, pause it
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            GameObject trampBall = GameObject.Find("/TrampBall");
            Destroy(trampBall.GetComponent<FixedJoint>());
        }
    }
}
