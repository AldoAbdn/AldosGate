using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelectMenu : MonoBehaviour
{
    static public int NumPlayers = 1;

    public void StartButtonClick()
    {
        // Load game scene
        SceneManager.LoadScene(1);
    }

    public void PlayerSliderOnValueChanged()
    {

    }
}
