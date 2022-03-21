using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SoundManager : MonoBehaviour
{
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
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
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
