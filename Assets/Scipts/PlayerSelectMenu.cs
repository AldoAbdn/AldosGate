using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectMenu : MonoBehaviour
{
    static public int NumPlayers = 1;
    public Slider PlayerSlider;

    public void PlayerSliderOnValueChanged()
    {
        NumPlayers = (int)PlayerSlider.value;
    }
}
