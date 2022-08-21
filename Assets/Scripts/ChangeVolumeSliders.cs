using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeSliders : MonoBehaviour {

    [SerializeField]
    private Slider soundSlider = null, musicSlider = null;

    private void Start() {
        soundSlider.value = Sound.SoundVolume;
        musicSlider.value = Sound.MusicVolume;
    }

    public void OnSoundSliderChange(float value) {
        Sound.SoundVolume = value;
    }

    public void OnMusicSliderChange(float value) {
        Sound.MusicVolume = value;
    }

}