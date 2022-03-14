using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCloser : MonoBehaviour
{
    public void EndGame()
    {
        Application.Quit();
        Debug.Log("Exiting");
        
    }
    
}
