using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    private AudioSource _sound;

    [SerializeField] private AudioMixerGroup group;
    [SerializeField] private bool isLooping = false;

    private void Start()
    {
        //Add component adds the component to the
        //gameobject you are on
        _sound = gameObject.AddComponent<AudioSource>();
        //if its a component we cant use:
        //_sound = new AudioSource();
        _sound.clip = _clip;

        _sound.outputAudioMixerGroup = group;
        _sound.loop = isLooping;
    }

    public void Play()
    {
        _sound.Play();
    }
}
