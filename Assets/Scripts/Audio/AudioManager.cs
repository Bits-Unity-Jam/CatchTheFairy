using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { private set; get; }
    public Sound[] sound;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        else Instance = this;

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sound)
        {
          s.source=gameObject.AddComponent<AudioSource>();// ініціюєм поле source додаючи компонент до this gameobject
          s.source.clip = s.clip;

          s.source.volume = s.volume;                   // встановлюєм властивості на цей компоненд
          s.source.pitch = s.pitch;
          s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
      Sound s =  Array.Find(sound, sound => sound.name == name); 
        if (s!=null)
        {
            s.source.Play();
        }
        else
        {
            Debug.LogWarning($"Sound with name{name} wasn't found!!!");
        }
    }
}
