using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, IExplode
{
    public void Explode()
    {
        Debug.Log(gameObject.name + " explodes in a large fireball!");
    }
}
