using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    public float volume;
    public float pitch;
    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
