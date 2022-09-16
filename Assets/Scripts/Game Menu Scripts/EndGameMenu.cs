using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CanvasGroup))]

public class EndGameMenu : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();

        // Check if component not found

        if (canvasGroup == null)
        {
            Debug.LogError("canvasGroup Component Not Found!");
        }

        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0f;
        Time.timeScale = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameStats.currentHealth <= 0)
        {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1f;
            Time.timeScale = 0f;
        }
    }
}