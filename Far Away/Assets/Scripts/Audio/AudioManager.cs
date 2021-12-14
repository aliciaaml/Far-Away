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
    Scene previousScene;

    bool running = false;
    bool sceneChange = false;

    bool capilla = false;
    bool comunicacions = false;
    bool ayuntamiento = false;

    public float mult;

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
        mult = 1f;
        // Create a temporary reference to the current scene.
        currentScene = SceneManager.GetActiveScene();

        previousScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        sceneName = currentScene.name;

        if (sceneName == "Nivel1Exterior")
        {
            Play("Naturaleza");
            VolumeIn("Naturaleza", mult);

            Timer("Cuervos", mult);
        }

        else if (sceneName == "Nivel2Exterior")
        {
            Play("Naturaleza");
            VolumeIn("Naturaleza", mult);

            Timer("Cuervos", mult);
        }

        else if (sceneName == "Nivel3Exterior")
        {
            Play("Naturaleza");
            VolumeIn("Naturaleza", mult);

            Timer("Cuervos", mult);
        }
    }

    private void Update()
    {
        previousScene = currentScene;
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (previousScene.name != sceneName)
        {
            sceneChange = true;
        }
        else sceneChange = false;


        if (sceneChange)
        {
            if (sceneName == "Casa3")
            {
                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);

                if (capilla)
                {
                    mult = 0.5f;
                    VolumeOut("Tema 2 Tension 1", 1f);
                    Play("Corazon");
                    VolumeIn("Corazon", mult);
                }
                else
                {
                    StopCoroutine("TimerCoroutine");
                    mult = 0.15f;

                    Timer("Cuervos", mult);
                }
            }

            else if (sceneName == "Casa2")
            {
                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);

                if (capilla)
                {
                    mult = 0.5f;
                    VolumeOut("Tema 2 Tension 1", 1f);
                    Play("Corazon");
                    VolumeIn("Corazon", mult);
                }
                else
                {
                    StopCoroutine("TimerCoroutine");
                    mult = 0.15f;

                    Timer("Cuervos", mult);
                }
            }

            else if (sceneName == "Casa4")
            {
                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);

                if (capilla)
                {
                    mult = 0.5f;
                    VolumeOut("Tema 2 Tension 1", 1f);
                    Play("Corazon");
                    VolumeIn("Corazon", mult);
                }
                else
                {
                    StopCoroutine("TimerCoroutine");
                    mult = 0.15f;

                    Timer("Cuervos", mult);
                }
            }

            else if (sceneName == "Casa5")
            {
                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);

                if (capilla)
                {
                    mult = 0.5f;
                    VolumeOut("Tema 2 Tension 1", 1f);
                    Play("Corazon");
                    VolumeIn("Corazon", mult);
                }
                else
                {
                    StopCoroutine("TimerCoroutine");
                    mult = 0.15f;

                    Timer("Cuervos", mult);
                }                
            }

            else if (sceneName == "Sala_comunicaciones")
            {
                comunicacions = true;

                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);

                mult = 0.15f;
                VolumeOut("Tema 2 Tension 1", 1f);
                Play("Corazon");
                VolumeIn("Corazon", mult);

                Play("Tema 3 Tension 1");
                VolumeIn("Tema 3 Tension 1", mult);

                StopCoroutine("TimerCoroutine");

                Timer("Cuervos", mult);
            }

            else if (sceneName == "Ayuntamiento")
            {
                ayuntamiento = true;

                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);

                if (capilla)
                {
                    mult = 0.15f;
                    VolumeOut("Tema 2 Tension 1", 1f);
                    Play("Corazon");
                    VolumeIn("Corazon", mult);
                }
                else
                {
                    StopCoroutine("TimerCoroutine");
                    mult = 0.15f;

                    Play("Corazon");
                    VolumeIn("Corazon", mult);

                    //Timer("Cuervos", mult);
                }
            }

            else if (sceneName == "Hab_alcalde")
            {
                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);

                VolumeOut("Corazon", 1f);

                mult = 0.5f;
                VolumeOut("Tema 3 Tension 2", 1f);
                Play("Corazon");
                VolumeIn("Corazon", mult);

            }

            else if (sceneName == "Nivel1Exterior")
            {
                if (capilla)
                {
                    mult = 0.15f;
                    Play("Tema 2 Tension 1");
                    VolumeIn("Tema 2 Tension 1", mult);
                    VolumeOut("Corazon", mult);
                }

                else if (ayuntamiento)
                {
                    Play("Tema 3 Tension 3");
                    VolumeIn("Tema 3 Tension 2", mult);
                    VolumeOut("Corazon", mult);
                }

                else
                {
                    mult = 1f;
                    Play("Naturaleza");
                    VolumeIn("Naturaleza", mult);

                    Timer("Cuervos", mult);
                }

            }

            else if (sceneName == "Nivel2Exterior")
            {
                mult = 0.5f;

                if (capilla)
                {
                    Play("Tema 2 Tension 1");
                    VolumeIn("Tema 2 Tension 1", mult);
                    VolumeOut("Corazon", mult);
                }

                else if (ayuntamiento)
                {
                    Play("Tema 3 Tension 3");
                    VolumeIn("Tema 3 Tension 2", mult);
                    VolumeOut("Corazon", mult);
                }

                else
                {
                    mult = 1f;
                    Play("Naturaleza");
                    VolumeIn("Naturaleza", mult);

                    Timer("Cuervos", mult);
                }
            }

            else if (sceneName == "Nivel3Exterior")
            {
                mult = 0.5f;

                if (comunicacions)
                {
                        VolumeOut("Corazon", 1f);
                    Timer("Cuervos", mult);
                }

                else if (ayuntamiento)
                {
                    Play("Tema 3 Tension 3");
                    VolumeIn("Tema 3 Tension 2", mult);
                    VolumeOut("Corazon", mult);
                }

                else
                {
                    Play("Tema 2 Tension 1");
                    VolumeIn("Tema 2 Tension 1", mult);
                    VolumeOut("Corazon", mult);
                }
            }

            else if (sceneName == "Capilla")
            {
                capilla = true;

                VolumeOut("Naturaleza", 1f);

                VolumeOut("Cuervos", 1f);
                StopCoroutine("TimerCoroutine");
                mult = 0.15f;

                //Timer("Cuervos", mult);
                Play("Piano Tenso");
                VolumeIn("Piano Tenso", mult);

            }
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;
        s.source.Play();
        s.source.pitch = 1;

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

    public void VolumeIn(string name, float mult)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        StartCoroutine(VolumeInCoroutine(s, mult));
    }

    public void VolumeOut(string name, float mult)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        StartCoroutine(VolumeOutCoroutine(s, mult));
    }

    public void Timer(string name, float mult)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s == null) return;

        StartCoroutine(TimerCoroutine(s, mult));
    }

    IEnumerator VolumeInCoroutine(Sound s, float mult)
    {
        while (s.source.volume < 0.8f * mult)
        {
            s.source.volume += 0.003f * mult;
            yield return null;
        }
    }

    IEnumerator VolumeOutCoroutine(Sound s, float mult)
    {
        while (s.source.volume > 0f)
        {
            s.source.volume -= 0.0008f * mult;
            yield return null;
        }
    }

    IEnumerator TimerCoroutine(Sound s, float mult)
    {
        running = true;
        yield return new WaitForSecondsRealtime(30);
        Play(s.name);

        VolumeIn(s.name, mult);

        yield return new WaitForSecondsRealtime(5);
        VolumeOut(s.name, mult);
        running = false;

        yield return new WaitForSecondsRealtime(5);

        Timer(s.name, mult);
    }
}
