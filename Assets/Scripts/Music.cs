using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource audioSrc;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (audioSrc.isPlaying) return;
        audioSrc.Play();
    }

    public void StopMusic()
    {
        audioSrc.Stop();
    }
}
