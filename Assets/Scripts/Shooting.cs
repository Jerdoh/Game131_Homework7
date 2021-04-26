using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] public AudioClip hitBarrelSound;
    [SerializeField] public AudioClip shootingSound;
    [SerializeField] public AudioClip healingSound;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(!SoundPrefs.MuteShooting)
            {
                audioSource.PlayOneShot(shootingSound, SoundPrefs.ShootingVolume / 10f);
            }
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                
                MonoBehaviour[] mono;
                mono = objectHit.gameObject.GetComponents<MonoBehaviour>();

                foreach(MonoBehaviour item in mono)
                {
                    if(item is IDamage)
                    {
                        IDamage temp = item as IDamage;
                        temp.TakeDamage();
                        return;
                    }
                    if(item is IExplode)
                    {
                        IExplode temp = item as IExplode;
                        temp.Explode();
                        if(!SoundPrefs.MuteExplosion)
                        {
                            audioSource.PlayOneShot(hitBarrelSound, SoundPrefs.ExplosionVolume / 10f);
                        }
                        return;
                    }
                }
            }
        }

        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;

                MonoBehaviour[] mono;
                mono = objectHit.gameObject.GetComponents<MonoBehaviour>();

                foreach(MonoBehaviour item in mono)
                {
                    if(item is IHeal)
                    {
                        IHeal temp = item as IHeal;
                        temp.Heal();
                        if(!SoundPrefs.MuteHealing)
                        {
                            audioSource.PlayOneShot(healingSound);
                        }
                        return;
                    }
                }
            }
        }
    }
}
