
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

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
            s.source.outputAudioMixerGroup = s.mixer;
        }
    }

    private void Start()
    {
        PlaySound(namesound);
    }
    public void PlaySound(string name)
    {
        SoundScriptable s = System.Array.Find(scriptableSounds, sound => sound.naming == name);
        s.source.clip = s.clip[Random.Range(0, s.clip.Length)];
        s.source.Play();
    }

    public void Play(string name)
    {
        SoundScriptable s = System.Array.Find(scriptableSounds, sound => sound.naming == name);

        if (s.source.isPlaying)
        {
            return;
        }
        else
        {
            s.source.clip = s.clip[Random.Range(0, s.clip.Length)];
            s.source.pitch = Random.Range(.8F, 1.2F);
            s.source.Play();
        }
    }
    public void PlayEndJump(LandingInfos p_Infos)
    {
        if (p_Infos.fallingTime >= .5)
        {
            Play("EndJump");
        }
    }
    public void Stop(string name)
    {
        SoundScriptable s = System.Array.Find(scriptableSounds, sound => sound.naming == name);
        s.source.Stop();
    }
}
