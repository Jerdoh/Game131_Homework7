using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioWindow : EditorWindow
{
    static AudioWindow instance;
    static GameObject player = GameObject.Find("Player");
    static Shooting shootingObject;

    [MenuItem("Window/Volume Window")]

    public static void CreateWindow()
    {
        instance = EditorWindow.GetWindow<AudioWindow>();
        instance.Show();
    }
    private void OnGUI()
    {
        shootingObject = player.GetComponent<Shooting>();

        SoundPrefs.MuteBackgroundMusic = EditorGUILayout.Toggle("Mute background music:", SoundPrefs.MuteBackgroundMusic);
        SoundPrefs.MuteShooting = EditorGUILayout.Toggle("Mute shooting effect:", SoundPrefs.MuteShooting);
        SoundPrefs.MuteExplosion = EditorGUILayout.Toggle("Mute explosion effect:", SoundPrefs.MuteExplosion);
        SoundPrefs.MuteHealing = EditorGUILayout.Toggle("Mute healing effect:", SoundPrefs.MuteHealing);
        SoundPrefs.BackgroundMusicVolume = EditorGUILayout.IntSlider("Background volume:", SoundPrefs.BackgroundMusicVolume, 1, 10);
        SoundPrefs.ShootingVolume = EditorGUILayout.IntSlider("Shooting volume:", SoundPrefs.ShootingVolume, 1, 10);
        SoundPrefs.ExplosionVolume = EditorGUILayout.IntSlider("Explosion volume:", SoundPrefs.ExplosionVolume, 1, 10);
        SoundPrefs.HealingVolume = EditorGUILayout.IntSlider("Healing volume:", SoundPrefs.HealingVolume, 1, 10);

        if(GUILayout.Button("Play Shooting Effect"))
        {            
            player.GetComponent<AudioSource>().PlayOneShot(shootingObject.shootingSound, SoundPrefs.ShootingVolume / 10f);
        }

        if(GUILayout.Button("Play Explosion Effect"))
        {
            player.GetComponent<AudioSource>().PlayOneShot(shootingObject.hitBarrelSound, SoundPrefs.ExplosionVolume / 10f);
        }

        if(GUILayout.Button("Play Healing Effect"))
        {
            player.GetComponent<AudioSource>().PlayOneShot(shootingObject.healingSound, SoundPrefs.HealingVolume / 10f);
        }
    }
}
