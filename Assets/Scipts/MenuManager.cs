using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Public Properties
    public GameObject MainMenu;
    public GameObject PlayerSelectMenu;
    public GameObject MultiplayerMenu;
    public GameObject SettingsMenu;

    // Private Fields
    List<GameObject> menus = new List<GameObject>();

    public void SetMenu(int menu)
    {
        menus.ForEach(menuGameObject => menuGameObject.SetActive(false));
        menus[menu].SetActive(true);
    }

    void Awake()
    {
        // Setup Menus
        menus.Add(MainMenu);
        menus.Add(PlayerSelectMenu);
        menus.Add(MultiplayerMenu);
        menus.Add(SettingsMenu);
        // Set Initial State
        SetMenu(0);
    }
}
