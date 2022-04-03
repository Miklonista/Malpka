using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Serialization;

public class SoundManager : MonoBehaviour
{
    public Sound[] sounds;
    
    public static SoundManager Instance;
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource effectsSource;

    [Serializable]
    public struct Clips
    {
        public string name;
        public AudioClip audioClip;
    }

    [SerializeField]
    private List<Clips> audioClips;

    private readonly Dictionary<string, AudioClip> _audioClips = new Dictionary<string, AudioClip>();

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }
    private void Start()
    {
        foreach (var clip in audioClips) _audioClips[clip.name] = clip.audioClip;
    }

    public void PlaySound(string clipName)
    {
        effectsSource.PlayOneShot(_audioClips[clipName]);
    }

    public void UpdateMusic(string audioName)
    {
        if (!_audioClips.ContainsKey(audioName)) return;
        musicSource.clip = _audioClips[audioName];
        musicSource.Play();
    }
}
