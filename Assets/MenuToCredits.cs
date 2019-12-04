using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToCredits : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;

    public void ChangeToCredits()
    {
        credits.SetActive(true);
        mainMenu.SetActive(false);
    }
}
