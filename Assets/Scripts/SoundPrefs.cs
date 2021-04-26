using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
    using UnityEditor;
#endif

public class SoundPrefs
{
    public static bool MuteBackgroundMusic
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetBool("MuteBackgroundMusic", false);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetBool("MuteBackgroundMusic", value);
            #endif
        }
    }

    public static bool MuteShooting
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetBool("MuteShooting", false);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetBool("MuteShooting", value);
            #endif
        }
    }

    public static bool MuteExplosion
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetBool("MuteExplosion", false);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetBool("MuteExplosion", value);
            #endif
        }
    }

    public static bool MuteHealing
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetBool("MuteHealing", false);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetBool("MuteHealing", value);
            #endif
        }
    }

    public static int BackgroundMusicVolume
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetInt("BackgroundMusicVolume", 5);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetInt("BackgroundMusicVolume", value);
            #endif
        }
    }

    public static int ShootingVolume
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetInt("ShootingVolume", 5);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetInt("ShootingVolume", value);
            #endif
        }
    }

    public static int ExplosionVolume
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetInt("ExplosionVolume", 5);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetInt("ExplosionVolume", value);
            #endif
        }
    }

    public static int HealingVolume
    {
        get 
        {
            #if UNITY_EDITOR
                return EditorPrefs.GetInt("HealingVolume", 5);
            #else
                return false;
            #endif
        }

        set
        {
            #if UNITY_EDITOR
                EditorPrefs.SetInt("HealingVolume", value);
            #endif
        }
    }
}
