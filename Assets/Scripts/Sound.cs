using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Sound : MonoBehaviour {

    [SerializeField]
    private AudioClip[] audioClips = null;
    private static AudioClip[] audioClipsStatic;
    [SerializeField]
    private AudioClip musicForScene = null;

    private static float soundVolume = 1, musicVolume = .25f;
    public static float SoundVolume { get { return soundVolume; } set { soundVolume = value; } }
    public static float MusicVolume { get { return musicVolume; } set { musicSource.volume = musicVolume = value; } }

    private static AudioSource musicSource;

    private void Awake() {
        audioClipsStatic = audioClips;
        if (!musicSource) {
            GameObject musicObject = new GameObject("Music");
            DontDestroyOnLoad(musicObject);
            musicSource = musicObject.AddComponent<AudioSource>();
            musicSource.loop = true;
            musicSource.volume = musicVolume;
            musicSource.clip = musicForScene;
            musicSource.Play();
        } else {
            if (musicForScene.name != musicSource.clip.name) {
                musicSource.Stop();
                musicSource.clip = musicForScene;
                musicSource.Play();
            }
        }

    }

    public static void PlaySound(string soundName) {
        AudioClip clip = audioClipsStatic.FirstOrDefault(c => c.name == soundName);
        GameObject g = new GameObject(clip.name);
        AudioSource source = g.AddComponent<AudioSource>();
        source.clip = clip;
        source.volume = soundVolume;
        source.Play();
        g.AddComponent<DestroyOnSoundFinished>();
    }

}