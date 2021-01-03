using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public AudioSource music;
    public Slider musicSlider;


    private void Start()
    {
        music.volume = PlayerPrefs.GetFloat("volume");
        musicSlider.value = music.volume;
    }



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 45 * Time.deltaTime * music.volume * 8, 0);
    }


    public void MasterVolume(float mastVolume)
    {
        music.volume = mastVolume;
        PlayerPrefs.SetFloat("volume", music.volume);
        PlayerPrefs.Save();
    } 
}
