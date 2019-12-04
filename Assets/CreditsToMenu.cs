using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsToMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;

    public void ChangeToCredits()
    {
        mainMenu.SetActive(true);
        credits.SetActive(false);
    }
}
