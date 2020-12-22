
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public SoundScriptable[] scriptableSounds;
    [SerializeField]
    string namesound = null;

    private void Awake()
    {
        foreach (SoundScriptable s in scriptableSounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        //Play(namesound);
    }
    public void PlaySound(string name)
    {
       
    }

    public void Play(string name)
    {
        SoundScriptable s = System.Array.Find(scriptableSounds, sound => sound.naming == name);
        s.source.clip = s.clip[Random.Range(0, s.clip.Length)];
        s.source.pitch = Random.Range(.8F,1.2F);
        s.source.Play();
    }
    public void Stop(string name)
    {
        SoundScriptable s = System.Array.Find(scriptableSounds, sound => sound.naming == name);
        s.source.Stop();
    }
}
