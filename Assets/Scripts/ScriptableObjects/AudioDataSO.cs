using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioDataBase",menuName = "Audio/NewAudioData", order = 1)]
public class AudioDataSO : ScriptableObject
{
    [Serializable]
    public struct Clips
    {
        public string name;
        public AudioClip audioClip;
    }

    [SerializeField]
    private List<Clips> audioClips;

    private readonly Dictionary<string, AudioClip> _audioClips = new Dictionary<string, AudioClip>();

}
