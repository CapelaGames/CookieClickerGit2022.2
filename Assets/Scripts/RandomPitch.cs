using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RandomPitch : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    
    // Start is called before the first frame update
    void Start()
    {
        //set up audiomixer using code
        if (_audioMixer == null)
        {
            AudioSource source = GetComponent<AudioSource>();
            if (source != null)
            {
                _audioMixer = source.outputAudioMixerGroup.audioMixer;
            }
        }
    }

    public void Randomise()
    {
       // float buttonPitch;
        //_audioMixer.GetFloat("ButtonPitch",out buttonPitch);

        float randomPitch = Random.Range(0.8f, 1.2f);
        
        _audioMixer.SetFloat("ButtonPitch", randomPitch);
    }
}
