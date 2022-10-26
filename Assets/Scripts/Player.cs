
using Assets.Scripts;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rbd;
    public Platform CurrentPlatform;
    public Game Game;
    public AudioSource BounceSound;
    

   
    public void Bounce()
    {
        Rbd.velocity = new Vector3(0, BounceSpeed, 0);
        BounceSound.Play();
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rbd.velocity = Vector3.zero;
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rbd.velocity = Vector3.zero;
           
    }
}
