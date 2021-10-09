using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PunchSound : MonoBehaviour
{
    public AudioSource _audiosource;

    private void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }
    private void OnEnable()
    {
        PlayerCollision.collide += PlayAudio;
    }
    private void OnDisable()
    {
        PlayerCollision.collide -= PlayAudio;
    }
    private void PlayAudio()
    {
        _audiosource.Play();
    }
}
