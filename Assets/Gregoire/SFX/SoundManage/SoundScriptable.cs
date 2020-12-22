using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSound", menuName = "Sound")]
public class SoundScriptable : ScriptableObject
{
    public string naming = "NamingSound";

    public AudioClip[] clip = { };

    [Range(0, 1)]
    public float volume = .5f;

    public float pitch = 1;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
