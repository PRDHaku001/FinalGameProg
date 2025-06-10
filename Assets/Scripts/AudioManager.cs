using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource Music;

    public AudioClip Background;
    void Start()
    {
        Music.clip = Background;
        Music.Play();
    }

}
