using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource FinishSound;

  
    private void OnTriggerEnter(Collider other)
    {
        FinishSound.Play();
    }


}
