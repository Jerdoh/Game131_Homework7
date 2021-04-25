using UnityEngine;
using System.Collections;

public interface IDamage
{
    void TakeDamage();
}

public interface IHeal
{
    void Heal();
}

public interface IExplode
{
    void Explode();
}