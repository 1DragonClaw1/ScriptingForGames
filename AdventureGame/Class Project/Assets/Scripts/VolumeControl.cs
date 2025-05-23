using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;

    // Start is called before the first frame update
    private void Start()
    {
        volumeSlider.value = musicSource.volume;
        volumeSlider.onValueChanged.AddListener(AdjustVolume);
    }

    
    public void AdjustVolume(float newVolume)
    {
        musicSource.volume = newVolume;
    }
}
