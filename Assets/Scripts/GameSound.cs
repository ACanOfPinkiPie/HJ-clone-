using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSound : MonoBehaviour
{
    public AudioClip AudioClip;
    private AudioSource _audio;
    [Min(0)]
    public float Volume;
    [Min(0)]
    public float Delay;



    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _audio.PlayDelayed(Delay);

    }
    private void OnDisable()
    {
         _audio.Stop();
    }


}
