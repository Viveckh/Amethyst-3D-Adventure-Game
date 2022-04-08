using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private GameObject shieldGameObject;
    private bool isShieldActivated;
    private const float SHIELD_TIME = 5f;
    private bool startTimer = false;

    private float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        shieldGameObject = this.gameObject.transform.Find("Shield").gameObject;

        if (shieldGameObject == null)
        {
            Debug.Log("Could not find the shield game object.");
        }
        else
        {
            shieldGameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            toggleShield();
        }

        if (startTimer)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= SHIELD_TIME)
            {
                stopTimer();
            }
        }
    }

    void stopTimer()
    {
        startTimer = false;
        elapsedTime = 0f;

        shieldGameObject.SetActive(false);
    }

    void toggleShield()
    {
        isShieldActivated = !isShieldActivated;

        if (isShieldActivated)
        {
            shieldGameObject.SetActive(true);
            startTimer = true;
            Debug.Log("Shield is activated");
        }
        else
        {
            shieldGameObject.SetActive(false);
            stopTimer();
            Debug.Log("Shield is deactivated");
        }
    }
}
