using UnityEngine.Audio;
using UnityEngine;

// serializable allows us to embed a class with sub properties in the inspector
[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    
    [Range(0f, 1f)]
    public float volume;

    [Range(.1f, 3f)]
    public float pitch;

    public bool loop;

    [Range(0f, 1f)]
    public float spatialBlend;

    [HideInInspector]
    public AudioSource source;
}
