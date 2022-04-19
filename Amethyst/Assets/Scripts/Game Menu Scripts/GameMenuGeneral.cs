using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuGeneral : MonoBehaviour
{
    public GameObject missionObjectivePanel;
    public GameObject aboutPanel;

    public void showObjectives()
    {
        aboutPanel.SetActive(false);
        missionObjectivePanel.SetActive(true);
    }

    public void showAbout()
    {
        aboutPanel.SetActive(true);
        missionObjectivePanel.SetActive(false);
    }

    public void mainScreen()
    {
        aboutPanel.SetActive(false);
        missionObjectivePanel.SetActive(false);
    }
}
