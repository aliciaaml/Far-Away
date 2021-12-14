using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager inst;

    string sceneName;
    Scene currentScene;

    private void Awake()
    {
        if (inst == null)
        {
            inst = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            s.pitch = 1;
        }
    }
    private void Start()
    {
        // Create a temporary reference to the current scene.
        currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        sceneName = currentScene.name;

        if (sceneName == "Nivel1Exterior")
        {
            Play("Naturaleza");
            VolumeIn("Naturaleza");

            Timer("Cuervos");
        }

        else if (sceneName == "Nivel2Exterior")
        {
            // Do something...
        }

        else if (sceneName == "Nivel3Exterior")
        {
            // Do something...
        }
    }

    private void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "Nivel1Exterior")
        {
            //Timer("Cuervos");
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;
        s.source.Play();

        if (s.source.name == "Naturaleza")
        {
            s.source.loop = true;
        }
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;
        s.source.Stop();
    }

    public void VolumeIn(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        StartCoroutine(VolumeInCoroutine(s));
    }

    public void VolumeOut(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        StartCoroutine(VolumeOutCoroutine(s));
    }

    public void Timer(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        StartCoroutine(TimerCoroutine(s));
    }

    IEnumerator VolumeInCoroutine(Sound s)
    {
        while (s.source.volume < 0.8f)
        {
            s.source.volume += 0.003f;
            yield return null;
        }
    }

    IEnumerator VolumeOutCoroutine(Sound s)
    {
        while (s.source.volume > 0f)
        {
            s.source.volume -= 0.0008f;
            yield return null;
        }
    }

    IEnumerator TimerCoroutine(Sound s)
    {
        yield return new WaitForSecondsRealtime(30);
        Play(s.name);

        VolumeIn(s.name);
        Debug.Log("BBBBBBBBBB");

        yield return new WaitForSecondsRealtime(5);
        VolumeOut(s.name);

        Debug.Log("AAAAAAAAAA");
        yield return new WaitForSecondsRealtime(5);

        Timer(s.name);


    }
}
