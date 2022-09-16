using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class GameTutorialMenu : MonoBehaviour
{
    private PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
        

        if (director == null)
        {
            Debug.Log("Director does not exist");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            director.Stop();
            this.gameObject.SetActive(false);
        }
    }
}
