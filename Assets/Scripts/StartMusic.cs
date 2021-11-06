using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{

    private GameObject[] backgroundMusic;
    private AudioSource backMusic;

    void Awake()
    {
        backgroundMusic = GameObject.FindGameObjectsWithTag("Music");

        if (backgroundMusic.Length >= 2)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(transform.gameObject);
        backMusic = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (backMusic.isPlaying) return;
        backMusic.Play();
    }

    public void StopMusic()
    {
        backMusic.Stop();
    }
}
