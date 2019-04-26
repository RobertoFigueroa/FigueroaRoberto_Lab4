using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    public Slider _slider;
    public AudioSource _audio;
    // Update is called once per frame
    void Update()
    {
        _audio.volume = _slider.value;
    }
}
