using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMixer : MonoBehaviour
{

    public AudioSource Bgm;
    public float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Bgm.volume = musicVolume;
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume;
    }
}
