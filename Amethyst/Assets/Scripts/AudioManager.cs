using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public GameObject riverAudioPoint;
    public GameObject warehouseAudioPoint;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            if (s.name == "river") {
                s.source = riverAudioPoint.AddComponent<AudioSource>();
            }
            else if (s.name == "warehouse") {
                s.source = warehouseAudioPoint.AddComponent<AudioSource>();
            }
            else
            {
                // Attach the sound to audio manager by default
                s.source = gameObject.AddComponent<AudioSource>();
            }
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.spatialBlend = s.spatialBlend;
        }
    }

    void Start()
    {
        // Play the theme
        // Play("theme");
        Play("river"); // you can only hear when close to the river
        Play("warehouse"); // you can only hear when close to the warehouse
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
