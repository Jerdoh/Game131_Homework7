using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage, IHeal
{
    public int health;
    
    public void TakeDamage()
    {
        health--;
    }

    public void Heal()
    {
        health++;
    }
}
