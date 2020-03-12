using UnityEngine;
using UnityEngine.UI;

public class PlayerSelectMenu : MonoBehaviour
{
    static public int NumPlayers = 1;
    public Text Text;
    public Slider PlayerSlider;

    public void PlayerSliderOnValueChanged()
    {
        NumPlayers = (int)PlayerSlider.value;
        Text.text = PlayerSlider.value.ToString();
    }
}
