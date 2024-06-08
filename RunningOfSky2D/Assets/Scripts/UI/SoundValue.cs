using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundValue : MonoBehaviour
{
    public Slider Slider;

    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("Sound");
        Slider.value = PlayerPrefs.GetFloat("Sound");
    }

    public void SetVolume (float _volume)
    {
        AudioListener.volume = _volume;
        PlayerPrefs.SetFloat("Sound", AudioListener.volume);
    }
}
