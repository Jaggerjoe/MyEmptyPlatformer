using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "NewSound", menuName = "Sound")]
public class SoundScriptable : ScriptableObject
{
    public string naming = "NamingSound";

    public AudioClip[] clip = { };

    [Range(0, 1)]
    public float volume = .5f;

    public float pitch = 1;

    public bool loop;

    public AudioMixerGroup mixer = null;

    [HideInInspector]
    public AudioSource source;
}
